using System;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    public class Pub4
    {
        private event EventHandler<MyArgs> _onChange = delegate { };

        public event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (_onChange)
                {
                    _onChange += value;
                }
            }
            remove
            {
                lock (_onChange)
                {
                    _onChange -= value;
                }
            }
        }

        public void Raise()
        {
            _onChange(this, new MyArgs(45));
        }
    }
}
