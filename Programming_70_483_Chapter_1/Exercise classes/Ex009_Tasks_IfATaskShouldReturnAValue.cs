using System;
using System.Threading.Tasks;

namespace Programming_70_483_Chapter_1
{
    class Ex009_Tasks_IfATaskShouldReturnAValue : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - If a Task should return a value";

        public override int Number { get; set; } = 9;

        public Ex009_Tasks_IfATaskShouldReturnAValue() { }

        public override void Exec()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            Console.WriteLine(t.Result);
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}