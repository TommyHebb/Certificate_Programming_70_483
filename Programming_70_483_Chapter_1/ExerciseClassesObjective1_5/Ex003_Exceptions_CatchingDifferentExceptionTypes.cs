using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex003_Exceptions_CatchingDifferentExceptionTypes : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Catching different Exception Types";

        public override int Number { get; set; } = 3;

        public Ex003_Exceptions_CatchingDifferentExceptionTypes() { }

        public override void Exec()
        {
            while (true)
            {
                Console.WriteLine("Please enter something or nothing: ");
                string myString = Console.ReadLine();

                try
                {
                    int myInteger = int.Parse(myString);
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", myString);
                }
            }
        }
    }
}