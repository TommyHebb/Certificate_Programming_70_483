using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex001_Thread_Basic ex001 = new Ex001_Thread_Basic();
            Ex002_Thread_Background ex002 = new Ex002_Thread_Background();
            Ex003_Tasks_Basic ex003 = new Ex003_Tasks_Basic();

            Console.WriteLine(ex001.ToString());
            ex001.Exec();
            Console.WriteLine(ex002.ToString());
            ex002.Exec();
            Console.WriteLine(ex003.ToString());
            ex003.Exec();
        }
    }
}
