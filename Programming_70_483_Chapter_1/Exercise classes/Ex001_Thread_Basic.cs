using System;
using System.Threading;

namespace Programming_70_483_Chapter_1
{
    public class Ex001_Thread_Basic
    {
        public static void Exec()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Common.ThreadMethod));
            t.Start(1); // '1' is the param offered to the ThreadMethod.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(1);
            }
            t.Join();
        }
    }
}
