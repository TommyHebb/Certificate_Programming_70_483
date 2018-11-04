﻿using Programming_70_483_Chapter_1.Exercise_classes;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Programming_70_483_Chapter_1
{
    public class Ex003_Tasks_Basic : Exercise
    {
        public override string Name { get; set; } = "Ex003_Tasks_Basic";

        public Ex003_Tasks_Basic() { }

        public override void Exec()
        {
            Task<int>[] tasks = new Task<int>[3];
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }

        public override string ToString()
        {
            return string.Format("Oefening: {0} ", Name);
        }
    }
}