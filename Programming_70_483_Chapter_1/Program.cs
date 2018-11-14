using System;
using System.Linq;
using System.Reflection;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools consoleTools = new ConsoleTools();
            string nmspace = "Programming_70_483_Chapter_1";
            string startsWith = "Ex0";

            Exercise[] exercises = consoleTools.GetObjectArrayOfClasses(nmspace, startsWith) as Exercise[];
            /*
            var exercisesArray = from target in Assembly.GetExecutingAssembly().GetTypes()
                                 where target.IsClass && target.Namespace == nmspace && target.Name.StartsWith("Ex0")
                                 orderby target.Name
                                 select target;
            exercisesArray.ToArray();

            Exercise[] exercises = new Exercise[exercisesArray.Count()];
            Exercise myExercise;
            int index = 0;

            foreach (var clss in exercisesArray)
            {
                myExercise = Activator.CreateInstance(clss) as Exercise;
                exercises[index] = myExercise;
                index++;
                Console.WriteLine(myExercise.ToString());
            }
            Console.WriteLine();
            */
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
