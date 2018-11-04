using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    public class Ex001_Thread_Basic
    {
        public static void Exec()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(1); // '1' is the param offered to the ThreadMethod.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(1);
            }
            t.Join();
        }

        public static void ThreadMethod(object o)
        {
            ConsoleTools.Devider('-');
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep((int)o);
            }
            ConsoleTools.Devider('-');
        }
    }
}
