using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex001_UnderstandingDelegates_UsingADelegate : BaseExercise
    {
        public override string Name { get; set; } = "UnderstandingDelegates - Using a delegate";

        public override int Number { get; set; } = 1;

        public Ex001_UnderstandingDelegates_UsingADelegate() { }

        public override void Exec()
        {
            Common common = new Common();
            Common.Calculate calc = common.Add;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = common.Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
