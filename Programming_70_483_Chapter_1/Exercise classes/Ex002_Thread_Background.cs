using Programming_70_483_Chapter_1.Exercise_classes;
using System;
using System.Threading;

namespace Programming_70_483_Chapter_1
{
    public class Ex002_Thread_Background : Exercise
    {
        public override string Name { get; set; } = "Ex002_Thread_Background";

        public Ex002_Thread_Background() { }

        public override void Exec()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Common.ThreadMethod));
            t.IsBackground = false;
            // 'true' only makes sense if it's the last thing the console application has to do.
            // otherwise, the output will get written anyway.
            t.Start(100);
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} ", Name);
        }
    }
}
