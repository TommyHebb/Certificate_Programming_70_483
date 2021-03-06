﻿using System;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    class Ex017_Parallel_UsingParallelBreak : BaseExercise
    {
        public override string Name { get; set; } = "Parallel - Using Parallel.Break";

        public override int Number { get; set; } = 17;

        public Ex017_Parallel_UsingParallelBreak() { }

        public override void Exec()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });
        }
    }
}