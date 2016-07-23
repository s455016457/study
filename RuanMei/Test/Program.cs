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


            Console.Read();
        }
    }
}
