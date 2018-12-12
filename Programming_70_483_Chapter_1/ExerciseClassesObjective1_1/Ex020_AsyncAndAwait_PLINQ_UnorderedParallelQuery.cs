using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex020_AsyncAndAwait_PLINQ_UnorderedParallelQuery : BaseExercise
    {
        public override string Name { get; set; } = "Async and Await - PLINQ - Unordered parallel query";

        public override int Number { get; set; } = 20;

        public Ex020_AsyncAndAwait_PLINQ_UnorderedParallelQuery() { }

        public override void Exec()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                                        .Where(i => i % 2 == 0)
                                        .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}