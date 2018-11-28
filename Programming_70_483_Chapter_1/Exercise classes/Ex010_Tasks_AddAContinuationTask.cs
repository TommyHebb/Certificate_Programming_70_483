using System;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex010_Tasks_AddAContinuationTask : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - Add a continuation Task";

        public override int Number { get; set; } = 10;

        public Ex010_Tasks_AddAContinuationTask() { }

        public override void Exec()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}