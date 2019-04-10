using System;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_2
{
    class Ex007_CancellingTasks_AddingAContinuationForCanceledTasks : BaseExercise
    {
        public override string Name { get; set; } = "CancellingTasks - Adding a continuation for canceled tasks";

        public override int Number { get; set; } = 7;

        public Ex007_CancellingTasks_AddingAContinuationForCanceledTasks() { }

        private string LongRunningOperationCancellation(string s, int sec, CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();
            Thread.Sleep(sec);
            return s + " Completed";
        }

        public override void Exec()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            }, token).ContinueWith((t) =>
            {
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();

            cancellationTokenSource.Cancel();
            task.Wait();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
