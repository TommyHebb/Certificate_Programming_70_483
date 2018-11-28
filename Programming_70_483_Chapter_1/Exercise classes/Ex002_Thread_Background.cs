using System.Threading;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    public class Ex002_Thread_Background : BaseExercise
    {
        public override string Name { get; set; } = "Thread - Background";

        public override int Number { get; set; } = 2;

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
            return string.Format("Oefening: {0} - {1} ", Number, Name);
        }
    }
}
