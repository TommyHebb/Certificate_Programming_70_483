using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex019_AsyncAndAwait_PLINQ_UsingAsParallel : BaseExercise
    {
        public override string Name { get; set; } = "Async and Await - PLINQ - Using AsParallel";

        public override int Number { get; set; } = 19;

        public Ex019_AsyncAndAwait_PLINQ_UsingAsParallel() { }

        public override void Exec()
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel()
                                        .Where(i => i % 2 == 0)
                                        .ToArray();
        }
    }
}