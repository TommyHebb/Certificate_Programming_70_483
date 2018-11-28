using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex026_ConcurrentCollections_UsingGetConsumingEnumerableOnABlockingCollection : BaseExercise
    {
        public override string Name { get; set; } = "Concurrent Collections - Using GetConsumingEnumerable on a BlockingCollection<T>";

        public override int Number { get; set; } = 26;

        public Ex026_ConcurrentCollections_UsingGetConsumingEnumerableOnABlockingCollection() { }

        public override void Exec()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(v);
                }
            });
        }
    }
}