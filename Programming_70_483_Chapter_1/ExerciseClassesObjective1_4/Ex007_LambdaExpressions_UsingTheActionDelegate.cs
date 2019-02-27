using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex007_LambdaExpressions_UsingTheActionDelegate : BaseExercise
    {
        public override string Name { get; set; } = "LambdaExpressions - Using the Action Delegate";

        public override int Number { get; set; } = 7;

        public Ex007_LambdaExpressions_UsingTheActionDelegate() { }

        public override void Exec()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            calc(3, 4); // Displays 7
        }
    }
}
