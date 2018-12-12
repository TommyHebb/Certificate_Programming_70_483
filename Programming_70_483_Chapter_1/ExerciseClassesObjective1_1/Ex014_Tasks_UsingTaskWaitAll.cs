using System;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex014_Tasks_UsingTaskWaitAll : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - Using Task.WaitAll";

        public override int Number { get; set; } = 14;

        public Ex014_Tasks_UsingTaskWaitAll() { }

        public override void Exec()
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("1"); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("2"); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("3"); return 3; });
            Task.WaitAll(tasks);
        }
    }
}