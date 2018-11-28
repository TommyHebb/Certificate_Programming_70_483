using System;
using System.Threading;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex004_Tasks_SharedVariableToStopAThread : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - Shared variable to stop a thread";

        public override int Number { get; set; } = 4;

        public Ex004_Tasks_SharedVariableToStopAThread() { }

        public override void Exec()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Press any key to exit this exercise");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}
