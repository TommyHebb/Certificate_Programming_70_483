using System;
using System.Threading.Tasks;

namespace Programming_70_483_Chapter_1
{
    class Ex011_Tasks_SchedulingDifferentContinuationTasks : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - Scheduling different continuation Tasks";

        public override int Number { get; set; } = 11;

        public Ex011_Tasks_SchedulingDifferentContinuationTasks() { }

    public override void Exec()
    {
        Task<int> t = Task.Run(() => { return 42; });
        t.ContinueWith((i) =>
        {
            Console.WriteLine("Canceled");
        },  TaskContinuationOptions.OnlyOnCanceled);
        t.ContinueWith((i) =>
        {
            Console.WriteLine("Faulted");
        },  TaskContinuationOptions.OnlyOnFaulted);
        var completedTask = t.ContinueWith((i) =>
        {
            Console.WriteLine("Completed");
        },  TaskContinuationOptions.OnlyOnRanToCompletion);
        completedTask.Wait();
    }

    public override string ToString()
    {
        return string.Format("Oefening: {0} - {1} ", Number, Name);
    }
}
}