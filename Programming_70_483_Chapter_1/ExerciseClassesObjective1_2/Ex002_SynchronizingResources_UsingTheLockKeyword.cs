using System;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_2
{
    class Ex002_SynchronizingResources_UsingTheLockKeyword : BaseExercise
    {
        public override string Name { get; set; } = "SynchronizingResources - Using the lock keyword";

        public override int Number { get; set; } = 2;

        public Ex002_SynchronizingResources_UsingTheLockKeyword() { }

        public override void Exec()
        {
            int n = 0;
            object _lock = new object();
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock)
                    {
                        n++;
                    }
                }
            });
            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    n--;
                }
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}