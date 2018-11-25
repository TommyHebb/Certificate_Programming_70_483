using System;

namespace Programming_70_483_Chapter_1
{
    class Ex018_AsyncAndAwait_SimpleExample : BaseExercise
    {
        public override string Name { get; set; } = "Async and Await - Simple example";

        public override int Number { get; set; } = 18;

        public Ex018_AsyncAndAwait_SimpleExample() { }

        public override void Exec()
        {
            // Uses static method DownloadContent
            string result = Common.DownloadContent().Result;
            Console.WriteLine(result);
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}