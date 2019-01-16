using System;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_2
{
    class Ex003_SynchronizingResources_UsingTheInterlockedClass : BaseExercise
    {
        public override string Name { get; set; } = "SynchronizingResources - Using the Interlocked class";

        public override int Number { get; set; } = 3;

        public Ex003_SynchronizingResources_UsingTheInterlockedClass() { }

        public override void Exec()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });
            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);
            up.Wait();
            Console.WriteLine(n);
        }
    }
}