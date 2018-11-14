using System;
using System.Linq;

namespace Programming_70_483_Chapter_1
{
    public abstract class Exercise
    {
        public abstract string Name { get; set; }

        public abstract int Number { get; set; }

        public abstract void Exec();

        public void NeedsExecution(int[] exerciseNumbersThatNeedExecution)
        {
            if (exerciseNumbersThatNeedExecution.Contains(this.Number))
            {
                Console.WriteLine("Executing exercise {0} ", this.Number);
                this.Exec();
            }
        }
    }
}
