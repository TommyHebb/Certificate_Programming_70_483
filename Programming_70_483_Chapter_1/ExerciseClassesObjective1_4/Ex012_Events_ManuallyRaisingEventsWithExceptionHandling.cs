using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex012_Events_ManuallyRaisingEventsWithExceptionHandling : BaseExercise
    {
        public override string Name { get; set; } = "Events - Manually Raising Events with Exception Handling";

        public override int Number { get; set; } = 12;

        public Ex012_Events_ManuallyRaisingEventsWithExceptionHandling() { }

        public override void Exec()
        {
            Pub6 publisher6 = new Pub6();

            publisher6.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            publisher6.OnChange += (sender, e)
                => { throw new Exception(); };

            publisher6.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            try
            {
                publisher6.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }
    }
}