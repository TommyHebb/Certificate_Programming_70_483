using System;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    public class MyArgs : EventArgs
    {
        public int Value { get; set; }

        public MyArgs(int value)
        {
            Value = value;
        }
    }
}
