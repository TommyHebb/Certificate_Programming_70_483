using System;
using System.Threading;

namespace Programming_70_483_Chapter_1
{
    public class Ex002_Thread_Background
    {
        public static void Exec()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Common.ThreadMethod));
            t.IsBackground = false;
            // 'true' only makes sense if it's the last thing the console application has to do.
            // otherwise, the output will get written anyway.
            t.Start(100);
        }
    }
}
