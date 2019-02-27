using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex005_LambdaExpressions_LambdaExpressionToCreateADelegate : BaseExercise
    {
        public override string Name { get; set; } = "LambdaExpressions - Lambda Expression to create a Delegate";

        public override int Number { get; set; } = 5;

        public Ex005_LambdaExpressions_LambdaExpressionToCreateADelegate() { }

        public override void Exec()
        {
            Common.Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
