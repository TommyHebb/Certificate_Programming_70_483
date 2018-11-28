using System;
using System.Collections.Concurrent;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Ex029_ConcurrentCollections_UsingAConcurrentStack : BaseExercise
    {
        public override string Name { get; set; } = "ConcurrentCollections - Using a ConcurrentStack";

        public override int Number { get; set; } = 29;

        public Ex029_ConcurrentCollections_UsingAConcurrentStack() { }

        public override void Exec()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);
            if (stack.TryPop(out int result))
            {
                Console.WriteLine("Popped: {0}", result);
            }
            stack.PushRange(new int[] { 1, 2, 3 });
            int[] values = new int[2];
            stack.TryPopRange(values);
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
        }
    }
}