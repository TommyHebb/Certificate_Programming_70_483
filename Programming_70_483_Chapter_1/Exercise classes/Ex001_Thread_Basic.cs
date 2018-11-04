﻿using Programming_70_483_Chapter_1.Exercise_classes;
using System;
using System.Threading;

namespace Programming_70_483_Chapter_1
{
    public class Ex001_Thread_Basic : Exercise
    {
        public override string Name { get; set; } = "Ex001_Thread_Basic";

        public Ex001_Thread_Basic() { }

        public override void Exec()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Common.ThreadMethod));
            t.Start(1); // '1' is the param offered to the ThreadMethod.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(1);
            }
            t.Join();
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} ", Name);
        }
    }
}
