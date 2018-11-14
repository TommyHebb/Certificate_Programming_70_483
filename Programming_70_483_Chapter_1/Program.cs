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
            string nspace = "Programming_70_483_Chapter_1";
            var exercisesArray = from target in Assembly.GetExecutingAssembly().GetTypes()
                                 where target.IsClass && target.Namespace == nspace && target.Name.StartsWith("Ex0")
                                 orderby target.Name
                                 select target;
            exercisesArray.ToArray();

            Exercise[] exercises = new Exercise[exercisesArray.Count()];
            int index = 0;

            foreach (var clss in exercisesArray)
            {
                exercises[index] = Activator.CreateInstance(clss) as Exercise;
                Console.WriteLine(exercises[index].ToString());
                index++;
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
