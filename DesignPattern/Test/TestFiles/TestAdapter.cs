using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern;

namespace Test.TestFiles
{
    public class TestAdapter : TestBase
    {
        public override void Test(Action<Task[]> callBack)
        {
            Console.WriteLine("************************Begin调用自己的源码**************************");
            ISqlHelper sqlHelper = new SqlServerHelper();
            sqlHelper.Add();
            sqlHelper.Delete();
            sqlHelper.Update();
            sqlHelper.Search();


            ISqlHelper mysqlHelper = new MySQLHelper();
            mysqlHelper.Add();
            mysqlHelper.Delete();
            mysqlHelper.Update();
            mysqlHelper.Search();
            Console.WriteLine("************************End调用自己的源码**************************");

            Console.WriteLine("************************Begin通过适配器调用其他代码-类适配器**************************");
            ISqlHelper myLuceneAdapter = new MyLuceneAdapter();
            myLuceneAdapter.Add();
            myLuceneAdapter.Delete();
            myLuceneAdapter.Search();
            myLuceneAdapter.Update();
            Console.WriteLine("************************End通过适配器调用其他代码**************************");

            Console.WriteLine("************************Begin对象适配器PhoneApdapter**************************");
            XiaoMi xiaomi = new XiaoMi();
            xiaomi.Call();
            xiaomi.Message();

            Console.WriteLine("使用适配器，xiaomi丢失原有Message功能");
            var phoneApdapter = new PhoneApdapter(xiaomi);
            phoneApdapter.Call();
            phoneApdapter.Message();

            Console.WriteLine("使用适配器，dageda拥有适配器的Message功能");
            Dageda dageda = new Dageda();
            phoneApdapter = new PhoneApdapter(dageda);
            phoneApdapter.Call();
            phoneApdapter.Message();

            Console.WriteLine("************************End对象适配器PhoneApdapter**************************");

            callBack.Invoke(null);
        }
    }
}
