using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Common
    {
        public delegate int Calculate(int x, int y); // Used by: Ex001_UnderstandingDelegates_UsingADelegate
        public delegate void Delegate002(); // Used by: Ex002_UnderstandingDelegates_AMulticastDelegate

        public int Add(int x, int y)
        {
            return x + y; // Used by: Ex001_UnderstandingDelegates_UsingADelegate
        }

        public int Multiply(int x, int y)
        {
            return x * y; // Used by: Ex001_UnderstandingDelegates_UsingADelegate
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne"); // Used by: Ex002_UnderstandingDelegates_AMulticastDelegate
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo"); // Used by: Ex002_UnderstandingDelegates_AMulticastDelegate
        }

    }
}
