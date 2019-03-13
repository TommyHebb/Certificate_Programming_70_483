using System;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Pub3
    {
        public event EventHandler<MyArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
}