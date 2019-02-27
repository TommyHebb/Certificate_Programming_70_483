using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex008_Events_UsingAnActionToExposeAnEvent : BaseExercise
    {
        public override string Name { get; set; } = "Events - Using an Action to Expose an Event";

        public override int Number { get; set; } = 8;

        public Ex008_Events_UsingAnActionToExposeAnEvent() { }

        public override void Exec()
        {
            Pub1 publisher = new Pub1();
            publisher.OnChange += () => Console.WriteLine("Event raised to method 1");
            publisher.OnChange += () => Console.WriteLine("Event raised to method 2");
            publisher.Raise();

            Pub2 publisher2 = new Pub2();
            publisher2.OnChange += () => Console.WriteLine("Event raised to method 3");
            publisher2.OnChange += () => Console.WriteLine("Event raised to method 4");
            publisher2.Raise();
        }
    }
}
