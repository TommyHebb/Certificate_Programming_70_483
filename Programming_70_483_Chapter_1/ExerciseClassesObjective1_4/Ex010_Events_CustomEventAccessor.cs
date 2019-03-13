using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex010_Events_CustomEventAccessor : BaseExercise
    {
        public override string Name { get; set; } = "Events - Custom Event Accessor";

        public override int Number { get; set; } = 10;

        public Ex010_Events_CustomEventAccessor() { }

        public override void Exec()
        {
            Pub4 publisher4 = new Pub4();
            publisher4.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
            publisher4.Raise();
        }
    }
}
