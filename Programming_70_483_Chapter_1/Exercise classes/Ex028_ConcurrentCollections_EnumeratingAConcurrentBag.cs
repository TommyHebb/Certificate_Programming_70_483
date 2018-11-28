using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex028_ConcurrentCollections_EnumeratingAConcurrentBag : BaseExercise
    {
        public override string Name { get; set; } = "Concurrent Collections - Enumerating a ConcurrentBag<T>";

        public override int Number { get; set; } = 28;

        public Ex028_ConcurrentCollections_EnumeratingAConcurrentBag() { }

        public override void Exec()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                foreach (int i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();
        }
    }
}