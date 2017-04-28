using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Begin测试SpeechSynthesizerHepler**************");
            TestBase test = ObjectFactory.CreatedObject<TestSpeech>();
            test.Test();
            Console.WriteLine("**************End测试SpeechSynthesizerHepler**************");

            Console.WriteLine("**************Begin测试Singleton**************");
            test = ObjectFactory.CreatedObject<TestSingleon>();
            test.Test();
            Console.WriteLine("**************End测试Singleton**************");

            Console.WriteLine("**************Begin测试Cache**************");
            test = ObjectFactory.CreatedObject<TestCache>();
            test.Test();
            Console.WriteLine("**************End测试Cache**************");

            Console.WriteLine("**************Begin测试Emit**************");
            test = ObjectFactory.CreatedObject<TestEmit>();
            test.Test();
            Console.WriteLine("**************End测试Cache**************");

            Console.WriteLine("**************Begin测试IOHelper**************");
            test = ObjectFactory.CreatedObject<TestIOHelper>();
            test.Test();
            Console.WriteLine("**************End测试IOHelper**************");

            Console.WriteLine("**************Begin测试IOHelper**************");
            test = ObjectFactory.CreatedObject<TestFactory>();
            test.Test();
            Console.WriteLine("**************End测试IOHelper**************");

            Console.WriteLine("**************Begin测试TestDecoratorPattern**************");
            test = ObjectFactory.CreatedObject<TestDecoratorPattern>();
            test.Test();
            Console.WriteLine("**************End测试TestDecoratorPattern**************");

            Console.WriteLine("**************Begin测试TestVerifyCode**************");
            test = ObjectFactory.CreatedObject<TestVerifyCode>();
            test.Test();
            Console.WriteLine("**************End测试TestVerifyCode**************");

            Console.WriteLine("**************Begin测试TestMementoPatter**************");
            test = ObjectFactory.CreatedObject<TestMementoPatter>();
            test.Test();
            Console.WriteLine("**************End测试TestMementoPatter**************");

            Console.Read();
        }
    }
}
