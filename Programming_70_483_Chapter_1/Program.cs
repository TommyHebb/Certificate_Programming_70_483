using System;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO DO: 
            // BaseExercise afzonderen naar eigen project en namespace (eventueel in solution van DLL)

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ConsoleTools consoleTools = new ConsoleTools();
            string nmspace = "Programming_70_483_Chapter_1";
            string startsWith = "Ex";

            var classes = consoleTools.GetObjectArrayOfClasses(nmspace, startsWith);
            BaseExercise[] exercises = new BaseExercise[classes.Length];
            int index = 0;
            foreach (var clss in classes)
            {                
                exercises[index] = clss as BaseExercise;
                index++;
            }

            int[] exercisesToRun = new int[0];
            bool isNumber;
            do
            {
                Console.WriteLine("Please enter the exercise number you wish to run... (0 is not valid. Entering nothing quits the input) ");
                isNumber = int.TryParse(Console.ReadLine(), out int result);
                if (isNumber && result != 0)
                {
                    exercisesToRun = consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(result, exercisesToRun);
                    Console.Write("Exercise {0} added to list. ", result);
                }
            }
            while (isNumber);
            Console.WriteLine("Executing requested exercises.....");

            foreach (BaseExercise exercise in exercises)
            {
                exercise.NeedsExecution(exercisesToRun);
            }
        }
    }
}
