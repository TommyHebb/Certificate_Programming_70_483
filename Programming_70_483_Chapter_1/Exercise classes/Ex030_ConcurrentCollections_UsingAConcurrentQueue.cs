using System;
using System.Collections.Concurrent;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex030_ConcurrentCollections_UsingAConcurrentQueue : BaseExercise
    {
        public override string Name { get; set; } = "ConcurrentCollections - Using a ConcurrentQueue";

        public override int Number { get; set; } = 30;

        public Ex030_ConcurrentCollections_UsingAConcurrentQueue() { }

        public override void Exec()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            if (queue.TryDequeue(out int result))
                Console.WriteLine("Dequeued: {0}", result);
        }
    }
}