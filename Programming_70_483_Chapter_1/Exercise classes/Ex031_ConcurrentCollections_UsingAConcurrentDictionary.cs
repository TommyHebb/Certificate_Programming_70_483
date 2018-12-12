using System;
using System.Collections.Concurrent;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex031_ConcurrentCollections_UsingAConcurrentDictionary : BaseExercise
    {
        public override string Name { get; set; } = "ConcurrentCollections - Using A ConcurrentDictionary";

        public override int Number { get; set; } = 31;

        public Ex031_ConcurrentCollections_UsingAConcurrentDictionary() { }

        public override void Exec()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }
            dict["k1"] = 42; // Overwrite unconditionally
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}