using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex022_AsyncAndAwait_PLINQ_MakingAParallelQuerySequential : BaseExercise
    {
        public override string Name { get; set; } = "Async and Await - PLINQ - Making a parallel query sequential";

        public override int Number { get; set; } = 22;

        public Ex022_AsyncAndAwait_PLINQ_MakingAParallelQuerySequential() { }

        public override void Exec()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
                                        .Where(i => i % 2 == 0).AsSequential();
            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);
        }
    }
}