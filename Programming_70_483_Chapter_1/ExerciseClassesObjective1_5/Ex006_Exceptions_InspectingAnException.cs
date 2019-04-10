using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    class Ex006_Exceptions_InspectingAnException : BaseExercise
    {
        public override string Name { get; set; } = "Exceptions - Inspecting an Exception";

        public override int Number { get; set; } = 6;

        public Ex006_Exceptions_InspectingAnException() { }

        public override void Exec()
        {
            try
            {
                Console.WriteLine("Please enter a number... ");
                int myInteger = Common.ReadAndParse();
                Console.WriteLine("Parsed: {0}", myInteger);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Message: {0}",e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
                Console.WriteLine("HelpLink: {0}", e.HelpLink);
                Console.WriteLine("InnerException: {0}", e.InnerException);
                Console.WriteLine("TargetSite: {0}", e.TargetSite);
                Console.WriteLine("Source: {0}", e.Source);
            }
        }
    }
}
