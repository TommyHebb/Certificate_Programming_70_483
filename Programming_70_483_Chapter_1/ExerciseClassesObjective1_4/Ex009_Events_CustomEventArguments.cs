using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex009_Events_CustomEventArguments : BaseExercise
    {
        public override string Name { get; set; } = "Events - Custom Event Arguments";

        public override int Number { get; set; } = 9;

        public Ex009_Events_CustomEventArguments() { }

        public override void Exec()
        {
            Pub3 publisher3 = new Pub3();
            publisher3.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);
            publisher3.Raise();
        }
    }
}