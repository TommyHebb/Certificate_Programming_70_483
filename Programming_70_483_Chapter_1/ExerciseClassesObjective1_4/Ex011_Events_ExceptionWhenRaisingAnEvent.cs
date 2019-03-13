using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex011_Events_ExceptionWhenRaisingAnEvent : BaseExercise
    {
        public override string Name { get; set; } = "Events - Exception when Raising an Event";

        public override int Number { get; set; } = 11;

        public Ex011_Events_ExceptionWhenRaisingAnEvent() { }

        public override void Exec()
        {
            Pub5 publisher5 = new Pub5();

            publisher5.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            publisher5.OnChange += (sender, e)
                => { throw new Exception(); };

            publisher5.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            publisher5.Raise();
        }
    }
}