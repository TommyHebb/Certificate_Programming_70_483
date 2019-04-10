using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex005_Exceptions_UsingEnvironmentFailFast : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Using Environment.FailFast";

        public override int Number { get; set; } = 5;

        public Ex005_Exceptions_UsingEnvironmentFailFast() { }

        public override void Exec()
        {
            Console.WriteLine("Please enter a number... ");
            string myString = Console.ReadLine();

            try
            {
                int myInteger = int.Parse(myString);
                if (myInteger == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
