using System;
using System.Runtime.ExceptionServices;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex008_Exceptions_UsingExceptionDispatchInfoThrow : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Using ExceptionDispatchInfo.Throw";

        public override int Number { get; set; } = 8;

        public Ex008_Exceptions_UsingExceptionDispatchInfoThrow() { }

        public override void Exec()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                Console.WriteLine("Please enter a number... ");
                string myString = Console.ReadLine();
                int.Parse(myString);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
