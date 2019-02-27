using System;
using System.IO;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex004_UnderstandingDelegates_ContravarianceWithDelegates : BaseExercise
    {
        public override string Name { get; set; } = "UnderstandingDelegates - Contravariance with Delegates";

        public override int Number { get; set; } = 4;

        public Ex004_UnderstandingDelegates_ContravarianceWithDelegates() { }

        public override void Exec()
        {
            Common common = new Common();
            StreamWriter writer = new StreamWriter("Something...");
            Common.ContravarianceDelegate myContravarDel = common.Write;
            myContravarDel(writer);
        }
    }
}
