using System;
using System.Threading.Tasks;

namespace Programming_70_483_Chapter_1
{
    class Ex012_Tasks_AttachingChildTasksToAParentTask : BaseExercise
    {
        public override string Name { get; set; } = "Tasks - Attaching child Tasks to a parent Task";

        public override int Number { get; set; } = 12;

        public Ex012_Tasks_AttachingChildTasksToAParentTask() { }

    public override void Exec()
    {
        Task<Int32[]> parent = Task.Run(() =>
        {
            var results = new Int32[3];
            new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
            new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
            new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
            return results;
        });
        var finalTask = parent.ContinueWith(parentTask =>
        {
            foreach (int i in parentTask.Result)
                Console.WriteLine(i);
        });
        finalTask.Wait();
    }

    public override string ToString()
    {
        return string.Format("Oefening: {0} - {1} ", Number, Name);
    }
}
}