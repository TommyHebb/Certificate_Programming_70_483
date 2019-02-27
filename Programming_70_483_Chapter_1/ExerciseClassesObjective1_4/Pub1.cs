using System;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Pub1
    {
        public Action OnChange { get; set; }
        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }
}