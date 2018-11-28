using System;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 3 * 2, Console.LargestWindowHeight / 3 * 2);

            ConsoleTools consoleTools = new ConsoleTools();
            ArrayTools arrayTools = new ArrayTools();

            string nmspace = "Programming_70_483_Chapter_1";
            string startsWith = "Ex";

            var classes = arrayTools.GetObjectArrayOfClasses(nmspace, startsWith);
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
                    exercisesToRun = arrayTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(result, exercisesToRun);
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
