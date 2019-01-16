using System;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_2
{
    class Ex004_SynchronizingResources_CompareAndExchangeAsANonatomicOperation : BaseExercise
    {
        public override string Name { get; set; } = "SynchronizingResources - Compare and exchange as a nonatomic operation";

        public override int Number { get; set; } = 4;

        public Ex004_SynchronizingResources_CompareAndExchangeAsANonatomicOperation() { }

        public override void Exec()
        {
            Task t1 = Task.Run(() =>
            {
                if (Common._Ex004_value == 1)
                {
                    Thread.Sleep(1000); // Removing this line will change the output
                    Common._Ex004_value = 2;
                }
            });
            Task t2 = Task.Run(() =>
            {
                Common._Ex004_value = 3;
            });
            Task.WaitAll(t1, t2);
            Console.WriteLine(Common._Ex004_value);
        }
    }
}