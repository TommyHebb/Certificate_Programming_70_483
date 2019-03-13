using System;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    public class Pub2
    {
        public event Action OnChange = delegate { };

        public void Raise()
        {
            OnChange();
        }
    }
}
