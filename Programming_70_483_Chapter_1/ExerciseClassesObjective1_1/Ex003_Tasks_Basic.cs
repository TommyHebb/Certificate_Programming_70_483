using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_1
{
    public class Ex003_Tasks_Basic : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - Basic";

        public override int Number { get; set; } = 3;

        public Ex003_Tasks_Basic() { }

        public override void Exec()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Common.ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}
