using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex002_UnderstandingDelegates_AMulticastDelegate : BaseExercise
    {
        public override string Name { get; set; } = "UnderstandingDelegates - A Multicast Delegate";

        public override int Number { get; set; } = 2;

        public Ex002_UnderstandingDelegates_AMulticastDelegate() { }

        public override void Exec()
        {
            Common common = new Common();
            Common.Delegate002 myDelegates = common.MethodOne;
            myDelegates += common.MethodTwo;

            myDelegates();
            int invocationCount = myDelegates.GetInvocationList().GetLength(0);
            Console.WriteLine("Number of methods added to the delegate: {0} ", invocationCount);
            // Displays: 
            // MethodOne
            // MethodTwo
            // Number of methods added to the delegate: 2
        }
    }
}
