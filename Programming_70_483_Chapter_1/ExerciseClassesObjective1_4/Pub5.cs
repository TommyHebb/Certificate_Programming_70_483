using System;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    public class Pub5
    {
        public event EventHandler OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }
}
