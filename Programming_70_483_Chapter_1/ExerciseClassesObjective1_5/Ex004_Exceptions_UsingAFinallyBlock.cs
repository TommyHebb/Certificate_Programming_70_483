using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex004_Exceptions_UsingAFinallyBlock : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Using a Finally Block";

        public override int Number { get; set; } = 4;

        public Ex004_Exceptions_UsingAFinallyBlock() { }

        public override void Exec()
        {
            Console.WriteLine("Please enter a number... ");
            string myString = Console.ReadLine();

            try
            {
                int myInteger = int.Parse(myString);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again", myString);
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
