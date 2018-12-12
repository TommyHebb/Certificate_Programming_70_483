using System;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_2
{
    class Ex001_SynchronizingResources_AccessingSharedDataInAMultithreadedApplication : BaseExercise
    {
        public override string Name { get; set; } = "SynchronizingResources - Accessing shared data in a multithreaded application";

        public override int Number { get; set; } = 1;

        public Ex001_SynchronizingResources_AccessingSharedDataInAMultithreadedApplication() { }

        public override void Exec()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });
            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }
            up.Wait();
            Console.WriteLine(n);
        }
    }
}