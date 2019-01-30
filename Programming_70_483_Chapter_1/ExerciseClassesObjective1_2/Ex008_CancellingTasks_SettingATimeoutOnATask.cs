using System;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_2
{
    class Ex008_CancellingTasks_SettingATimeoutOnATask : BaseExercise
    {
        public override string Name { get; set; } = "CancellingTasks - Setting a timeout on a task";

        public override int Number { get; set; } = 8;

        public Ex008_CancellingTasks_SettingATimeoutOnATask() { }

        public override void Exec()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });
            int index = Task.WaitAny(new[] { longRunning }, 1000);
            if (index == -1)
                Console.WriteLine("Task timed out");
        }
    }
}
