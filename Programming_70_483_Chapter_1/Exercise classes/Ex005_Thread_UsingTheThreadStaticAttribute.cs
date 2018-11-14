using System;
using System.Threading;

namespace Programming_70_483_Chapter_1
{
    class Ex005_Thread_UsingTheThreadStaticAttribute : Exercise
    {
        [ThreadStatic]
        public static int _field01;

        public override string Name { get; set; } = "Thread - Using the ThreadStaticAttribute";

        public override int Number { get; set; } = 5;

        public Ex005_Thread_UsingTheThreadStaticAttribute() { }

        public override void Exec()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field01++;
                    Console.WriteLine("Thread A: {0}", _field01);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field01++;
                    Console.WriteLine("Thread B: {0}", _field01);
                }
            }).Start();
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}
