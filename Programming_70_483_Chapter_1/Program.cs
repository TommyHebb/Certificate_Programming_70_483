using Programming_70_483_Chapter_1.Exercise_classes;
using System;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise[] exercises = new Exercise[5];
            exercises[0] = new Ex001_Thread_Basic();
            exercises[1] = new Ex002_Thread_Background();
            exercises[2] = new Ex003_Tasks_Basic();
            exercises[3] = new Ex004_Tasks_SharedVariableToStopAThread();
            exercises[4] = new Ex005_Thread_UsingTheThreadStaticAttribute();

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine(exercise.ToString());
            }
            Console.WriteLine();

            ConsoleTools consoleTools = new ConsoleTools();
            int[] exercisesToRun = new int[0];
            bool isNumber;

            do
            {
                Console.WriteLine("Please enter the exercise you wish to run... (0 is not valid) ");
                isNumber = int.TryParse(Console.ReadLine(), out int result);
                if (isNumber && result != 0)
                {
                    exercisesToRun = consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(result, exercisesToRun);
                    Console.Write("Exercise {0} added to list. ", result);
                }
            }
            while (isNumber);

            Console.WriteLine();

            foreach (Exercise exercise in exercises)
            {
                exercise.NeedsExecution(exercisesToRun);
            }
        }
    }
}
