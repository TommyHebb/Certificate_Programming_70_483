using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex023_AsyncAndAwait_PLINQ_UsingForAll : BaseExercise
    {
        public override string Name { get; set; } = "Async And Await - PLINQ - Using ForAll";

        public override int Number { get; set; } = 23;

        public Ex023_AsyncAndAwait_PLINQ_UsingForAll() { }

        public override void Exec()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                                        .Where(i => i % 2 == 0);
            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}