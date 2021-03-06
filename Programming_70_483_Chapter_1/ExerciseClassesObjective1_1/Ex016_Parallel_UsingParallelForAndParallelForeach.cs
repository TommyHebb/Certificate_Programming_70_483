﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex016_Parallel_UsingParallelForAndParallelForeach : BaseExercise
    {
        public override string Name { get; set; } = "Parallel - Using Parallel.For and Parallel.Foreach";

        public override int Number { get; set; } = 16;

        public Ex016_Parallel_UsingParallelForAndParallelForeach() { }

        public override void Exec()
        {
            Parallel.For(0, 10, i => { Thread.Sleep(1000); });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => { Thread.Sleep(1000); });
        }
    }
}