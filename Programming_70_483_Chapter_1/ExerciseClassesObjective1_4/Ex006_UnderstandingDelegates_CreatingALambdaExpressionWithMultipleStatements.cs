using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex006_UnderstandingDelegates_CreatingALambdaExpressionWithMultipleStatements : BaseExercise
    {
        public override string Name { get; set; } = "UnderstandingDelegates - Creating a Lambda Expression with Multiple Statements";

        public override int Number { get; set; } = 6;

        public Ex006_UnderstandingDelegates_CreatingALambdaExpressionWithMultipleStatements() { }

        public override void Exec()
        {
            Common.Calculate calc = (x, y) =>
            {
                Console.WriteLine("Adding numbers... ");
                return x + y;
            };

            int result = calc(3, 4); // Displays: Adding numbers... 
        }
    }
}
