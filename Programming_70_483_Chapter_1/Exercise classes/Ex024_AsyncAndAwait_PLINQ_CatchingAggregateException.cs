using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex024_AsyncAndAwait_PLINQ_CatchingAggregateException : BaseExercise
    {
        public override string Name { get; set; } = "Async And Await - PLINQ - Catching AggregateException";

        public override int Number { get; set; } = 24;

        public Ex024_AsyncAndAwait_PLINQ_CatchingAggregateException() { }

        public override void Exec()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                                            .Where(i => Common.IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
            }
        }
    }
}