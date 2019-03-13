using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex001_Exceptions_ParsingAnInvalidNumber : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Parsing an Invalid Number";

        public override int Number { get; set; } = 1;

        public Ex001_Exceptions_ParsingAnInvalidNumber() { }

        public override void Exec()
        {
            string myString = "NotANumber";
            int myInteger = int.Parse(myString);
        }
    }
}