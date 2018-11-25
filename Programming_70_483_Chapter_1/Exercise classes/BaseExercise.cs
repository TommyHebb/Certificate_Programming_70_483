﻿using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    public abstract class BaseExercise
    {
        public abstract string Name { get; set; }

        public abstract int Number { get; set; }

        public abstract void Exec();

        public void NeedsExecution(int[] exerciseNumbersThatNeedExecution)
        {
            if (exerciseNumbersThatNeedExecution.Contains(this.Number))
            {
                ConsoleTools.Devider();
                Console.WriteLine("Executing exercise {0}... ", this.Number);
                ConsoleTools.Devider('-', 25);
                this.Exec();
            }
        }
    }
}
