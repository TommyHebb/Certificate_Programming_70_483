using System;
using System.Collections.Concurrent;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex027_ConcurrentCollections_UsingAConcurrentBag : BaseExercise
    {
        public override string Name { get; set; } = "Concurrent Collections - Using a ConcurrentBag<T>";

        public override int Number { get; set; } = 27;

        public Ex027_ConcurrentCollections_UsingAConcurrentBag() { }

        public override void Exec()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);
            int result;
            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }
            if (bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next item: {0}", result);
            }
        }
    }
}