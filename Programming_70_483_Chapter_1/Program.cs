using Programming_70_483_Chapter_1.Exercise_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
