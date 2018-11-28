using System;
using System.Threading;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex006_Thread_UsingThreadLocal : BaseExercise
    {
        public override string Name { get; set; } = "Thread - Using ThreadLocal<T>";

        public override int Number { get; set; } = 6;

        public Ex006_Thread_UsingThreadLocal() { }

        public override void Exec()
        {
            new Thread(() =>
            {
                for (int x = 0; x < Common._field02.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < Common._field02.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}