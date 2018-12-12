using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex025_ConcurrentCollections_UsingBlockingCollection : BaseExercise
    {
        public override string Name { get; set; } = "Concurrent Collections - Using BlockingCollection<T>";

        public override int Number { get; set; } = 25;

        public Ex025_ConcurrentCollections_UsingBlockingCollection() { }

        public override void Exec()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });
            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();
        }
    }
}