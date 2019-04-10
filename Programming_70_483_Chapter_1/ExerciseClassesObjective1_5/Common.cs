using System;
using System.IO;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_5
{
    public class Common
    {
        public static int ReadAndParse()
        {
            string myString = Console.ReadLine();
            int myInteger = int.Parse(myString);
            return myInteger; // Used by: Ex006_Exceptions_InspectingAnException
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("fileName", "Filename is required");
            return File.ReadAllText(fileName); // Used by: Ex007_Exceptions_ThrowingAnArgumentNullException
        }
    }
}
