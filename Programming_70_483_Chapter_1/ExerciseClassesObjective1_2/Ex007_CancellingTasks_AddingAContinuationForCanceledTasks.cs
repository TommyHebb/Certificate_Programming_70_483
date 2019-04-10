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

        private string LongRunningOperationCancellation(string s, int sec,CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();
            Thread.Sleep(sec);
            return s + " Completed";
        }

        public override void Exec()
        {
            /*
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            }, token);

            Task continuationTask = task.ContinueWith(t =>
            {
                t.Exception.Handle((e) => true);
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();

            cancellationTokenSource.Cancel();
            continuationTask.Wait();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
            */
            CancellationTokenSource source = new CancellationTokenSource();
            source.Cancel();

            Task<string> t = Task.Run(() =>
                LongRunningOperationCancellation("Continuewith", 1500,
                    source.Token), source.Token);

            t.ContinueWith((t1) =>
            {
                if (t1.Status == TaskStatus.RanToCompletion)
                    Console.WriteLine(t1.Result);
                else if (t1.IsCanceled)
                    Console.WriteLine("Task cancelled");
                else if (t.IsFaulted)
                {
                    Console.WriteLine("Error: " + t.Exception.Message);
                }
            },TaskContinuationOptions.OnlyOnRanToCompletion);
        }
    }
}
