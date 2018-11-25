using System;
using System.Threading;

namespace Programming_70_483_Chapter_1
{
    class Ex007_Thread_QueuingSomeWorkToTheThreadPool : BaseExercise
    {
        public override string Name { get; set; } = "Thread - Queuing some work to the thread pool";

        public override int Number { get; set; } = 7;

        public Ex007_Thread_QueuingSomeWorkToTheThreadPool() { }

    public override void Exec()
    {
        ThreadPool.QueueUserWorkItem((s) =>
        {
            Console.WriteLine("Working on a thread from threadpool");
        });
    }

    public override string ToString()
    {
        return string.Format("Oefening: {0} - {1} ", Number, Name);
    }
}
}