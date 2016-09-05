#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    $rootnamespace$
   文件名         :    Class1
   创建时间       :    2016/7/25 9:13:38
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    admin
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public class EmitWriteLineDemo
    {
        public static Type CreateDynamicType()
        {
            Type[] ctorParams = new Type[] {typeof(int),
                   typeof(int)};

            AppDomain myDomain = Thread.GetDomain();
            AssemblyName myAsmName = new AssemblyName();
            myAsmName.Name = "MyDynamicAssembly";

            //创建程序集
            // 这里设置AssemblyBuilderAccess.Run 会引发System.NotSupportedException: 瞬态程序集中不能有持久模块。
            AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(
                           myAsmName,
                           AssemblyBuilderAccess.RunAndSave);

            //创建程序集中模块
            ModuleBuilder pointModule = myAsmBuilder.DefineDynamicModule("PointModule",
                                         "Point.dll");

            //在程序集中添加对象
            TypeBuilder pointTypeBld = pointModule.DefineType("Point",
                                       TypeAttributes.Public);

            //定义属性
            FieldBuilder xField = pointTypeBld.DefineField("x", typeof(int),
                                                           FieldAttributes.Public);
            FieldBuilder yField = pointTypeBld.DefineField("y", typeof(int),
                                                           FieldAttributes.Public);


            Type objType = Type.GetType("System.Object");
            ConstructorInfo objCtor = objType.GetConstructor(new Type[0]);

            //创建构造函数
            ConstructorBuilder pointCtor = pointTypeBld.DefineConstructor(
                                        MethodAttributes.Public,
                                        CallingConventions.Standard,
                                        ctorParams);
            //获取构造函数
            ILGenerator ctorIL = pointCtor.GetILGenerator();


            //发送指令
            // First, you build the constructor.
            ctorIL.Emit(OpCodes.Ldarg_0);
            ctorIL.Emit(OpCodes.Call, objCtor);
            ctorIL.Emit(OpCodes.Ldarg_0);
            ctorIL.Emit(OpCodes.Ldarg_1);
            ctorIL.Emit(OpCodes.Stfld, xField);
            ctorIL.Emit(OpCodes.Ldarg_0);
            ctorIL.Emit(OpCodes.Ldarg_2);
            ctorIL.Emit(OpCodes.Stfld, yField);
            ctorIL.Emit(OpCodes.Ret);

            //  Now, you'll build a method to output some information on the
            // inside your dynamic class. This method will have the following
            // definition in C#:
            //  public void WritePoint()
            //创建方法
            MethodBuilder writeStrMthd = pointTypeBld.DefineMethod(
                                          "WritePoint",
                                  MethodAttributes.Public,
                                                  typeof(void),
                                                  null);


            ILGenerator writeStrIL = writeStrMthd.GetILGenerator();

            // The below ILGenerator created demonstrates a few ways to create
            // string output through STDIN. 

            // ILGenerator.EmitWriteLine(string) will generate a ldstr and a 
            // call to WriteLine for you.

            writeStrIL.EmitWriteLine("WritePoint方法是Point中的方法输出：");
            writeStrIL.EmitWriteLine("The value of this current instance is:");

            // Here, you will do the hard work yourself. First, you need to create
            // the string we will be passing and obtain the correct WriteLine overload
            // for said string. In the below case, you are substituting in two values,
            // so the chosen overload is Console.WriteLine(string, object, object).

            String inStr = "({0}, {1})";
            Type[] wlParams = new Type[] {typeof(string),
                     typeof(object),
                     typeof(object)};

            // We need the MethodInfo to pass into EmitCall later.

            MethodInfo writeLineMI = typeof(Console).GetMethod(
                                 "WriteLine",
                             wlParams);

            // Push the string with the substitutions onto the stack.
            // This is the first argument for WriteLine - the string one. 

            writeStrIL.Emit(OpCodes.Ldstr, inStr);
            //writeStrIL.EmitWriteLine("x+y=" + (int.Parse(xField.GetValue(pointTypeBld).ToString()) + int.Parse(yField.GetValue(pointTypeBld).ToString())).ToString());

            // Since the second argument is an object, and it corresponds to
            // to the substitution for the value of our integer field, you 
            // need to box that field to an object. First, push a reference
            // to the current instance, and then push the value stored in
            // field 'x'. We need the reference to the current instance (stored
            // in local argument index 0) so Ldfld can load from the correct
            // instance (this one).

            writeStrIL.Emit(OpCodes.Ldarg_0);
            writeStrIL.Emit(OpCodes.Ldfld, xField);

            // Now, we execute the box opcode, which pops the value of field 'x',
            // returning a reference to the integer value boxed as an object.

            writeStrIL.Emit(OpCodes.Box, typeof(int));

            // Atop the stack, you'll find our string inStr, followed by a reference
            // to the boxed value of 'x'. Now, you need to likewise box field 'y'.

            writeStrIL.Emit(OpCodes.Ldarg_0);
            writeStrIL.Emit(OpCodes.Ldfld, yField);
            writeStrIL.Emit(OpCodes.Box, typeof(int));

            // Now, you have all of the arguments for your call to
            // Console.WriteLine(string, object, object) atop the stack:
            // the string InStr, a reference to the boxed value of 'x', and
            // a reference to the boxed value of 'y'.

            // Call Console.WriteLine(string, object, object) with EmitCall.

            writeStrIL.EmitCall(OpCodes.Call, writeLineMI, null);

            // Lastly, EmitWriteLine can also output the value of a field
            // using the overload EmitWriteLine(FieldInfo).

            writeStrIL.EmitWriteLine("WriteLine方法，是控制台方法输出：");
            writeStrIL.EmitWriteLine("The value of 'x' is:");
            writeStrIL.EmitWriteLine(xField);
            writeStrIL.EmitWriteLine("The value of 'y' is:");
            writeStrIL.EmitWriteLine(yField);

            // Since we return no value (void), the the ret opcode will not
            // return the top stack value.

            writeStrIL.Emit(OpCodes.Ret);

            return pointTypeBld.CreateType();
        }
    }
}