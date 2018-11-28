using System;
using System.Threading;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    public class Ex001_Thread_Basic : BaseExercise
    {
        public override string Name { get; set; } = "Thread - Basic";

        public override int Number { get; set; } = 1;

        public Ex001_Thread_Basic() { }

        public override void Exec()
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
