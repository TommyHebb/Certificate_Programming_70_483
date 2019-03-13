using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex002_Exceptions_CatchingAFormatException : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Catching a FormatException";

        public override int Number { get; set; } = 2;

        public Ex002_Exceptions_CatchingAFormatException() { }

        public override void Exec()
        {
            while (true)
            {
                Console.WriteLine("Please enter you first name: ");
                string myString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(myString))
                {
                    break;
                }

                try
                {
                    int myInteger = int.Parse(myString);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", myString);
                }
            }
        }
    }
}