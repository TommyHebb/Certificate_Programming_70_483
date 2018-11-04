using Programming_70_483_Chapter_1.Exercise_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise[] exercises = new Exercise[3];
            exercises[0] = new Ex001_Thread_Basic();
            exercises[1] = new Ex002_Thread_Background();
            exercises[2] = new Ex003_Tasks_Basic();

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine(exercise.ToString());
                //exercise.Exec();
            }

            Console.WriteLine("Please enter the exercises you wish to run...");
            int[] _specificExercisesToRun = ConsoleTools.GetSpecificExercisesToRun(); // Moet in eigen interface + UnitTests

            // Dan volgt, op zelfde interface, een uitvoerder (+ UnitTests), die _specificExercisesToRun binnenkrijgt als parameter en de nodige oefeningen uitvoert
        }
    }
}
