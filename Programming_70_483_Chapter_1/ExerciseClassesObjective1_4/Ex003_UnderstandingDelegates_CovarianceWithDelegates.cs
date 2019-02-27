using System;
using TommyTools;

namespace Programming_70_483_Chapter_1.ExerciseClassesObjective1_4
{
    class Ex003_UnderstandingDelegates_CovarianceWithDelegates : BaseExercise
    {
        public override string Name { get; set; } = "UnderstandingDelegates - Covariance with Delegates";

        public override int Number { get; set; } = 3;

        public Ex003_UnderstandingDelegates_CovarianceWithDelegates() { }

        public override void Exec()
        {
            Common common = new Common();
            Common.CovarianceDelegate myCovDel;
            myCovDel = common.MethodStream;
            myCovDel();
            myCovDel = common.MethodString;
            myCovDel();
        }
    }
}
