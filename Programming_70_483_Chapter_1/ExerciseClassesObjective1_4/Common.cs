using System;
using System.IO;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Common
    {
        public delegate int Calculate(int x, int y); // Used by: Ex001_UnderstandingDelegates_UsingADelegate, 
        // Ex005_LambdaExpressions_LambdaExpressionToCreateADelegate and 
        public delegate void Delegate002(); // Used by: Ex002_UnderstandingDelegates_AMulticastDelegate
        public delegate TextWriter CovarianceDelegate(); // Used by: Ex003_UnderstandingDelegates_CovarianceWithDelegates
        public delegate void ContravarianceDelegate(StreamWriter writer); // Used by: Ex004_UnderstandingDelegates_ContravarianceWithDelegates

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

        public StreamWriter MethodStream()
        {
            Console.WriteLine("StreamWriter being used... "); // Used by: Ex003_UnderstandingDelegates_CovarianceWithDelegates
            return null;
        } 
        public StringWriter MethodString()
        {
            Console.WriteLine("StringWriter being used... "); // Used by: Ex003_UnderstandingDelegates_CovarianceWithDelegates
            return null;
        }

        public void Write(TextWriter writer)
        {
            Console.WriteLine("Write, write, write, ... {0} ", writer.GetType()); // Used by: Ex004_UnderstandingDelegates_ContravarianceWithDelegates
        }
    }
}
