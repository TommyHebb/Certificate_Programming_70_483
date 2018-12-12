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
            if (dict.TryAdd("key1", 42))
            {
                Console.WriteLine("Added 42 to key1");
            }
            if (dict.TryUpdate("key1", 21, 42))
            {
                Console.WriteLine("42 updated to 21 for key1");
            }
            dict["key1"] = 42; // Overwrite unconditionally
            int r1 = dict.AddOrUpdate("key1", 3, (theKey, theValue) => theValue * 2);
            int r2 = dict.GetOrAdd("key2", 3);
            Console.WriteLine("r1 contains {0} and r2 contains {1}", r1, r2);
        }
    }
}