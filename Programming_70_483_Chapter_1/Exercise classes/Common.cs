using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    public class Common
    {
        public static void ThreadMethod(object o)
        {
            ConsoleTools.Devider('-');
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i); // Used by: Ex001_Thread_Basic AND Ex002_Thread_Background
                Thread.Sleep((int)o);
            }
            ConsoleTools.Devider('-');
        }

        public static ThreadLocal<int> _field02 = new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId; // Used by: Ex006_Thread_UsingThreadLocal
        });
    }
}
