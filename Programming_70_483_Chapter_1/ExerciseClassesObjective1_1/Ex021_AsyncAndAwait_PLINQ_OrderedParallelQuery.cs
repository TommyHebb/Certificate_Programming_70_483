﻿using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex021_AsyncAndAwait_PLINQ_OrderedParallelQuery : BaseExercise
    {
        public override string Name { get; set; } = "Async and Await - PLINQ - Ordered parallel query";

        public override int Number { get; set; } = 21;

        public Ex021_AsyncAndAwait_PLINQ_OrderedParallelQuery() { }

        public override void Exec()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                                        .Where(i => i % 2 == 0)
                                        .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}