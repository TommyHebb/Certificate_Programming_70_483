using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex007_Exceptions_ThrowingAnArgumentNullException : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Throwing an ArgumentNullException";

        public override int Number { get; set; } = 7;

        public Ex007_Exceptions_ThrowingAnArgumentNullException() { }

        public override void Exec()
        {
            Console.WriteLine("Please enter a filename... ");
            string fileName = Console.ReadLine();
            Common.OpenAndParse(fileName);
        }
    }
}
