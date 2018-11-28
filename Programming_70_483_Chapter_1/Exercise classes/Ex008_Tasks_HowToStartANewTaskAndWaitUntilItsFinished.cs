using System;
using System.Threading.Tasks;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex008_Tasks_HowToStartANewTaskAndWaitUntilItsFinished : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - How to start a new Task and wait until it’s finished";

        public override int Number { get; set; } = 8;

        public Ex008_Tasks_HowToStartANewTaskAndWaitUntilItsFinished() { }

        public override void Exec()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 50; x++)
                {
                    Console.Write('>');
                }
            });

            t.Wait();
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}