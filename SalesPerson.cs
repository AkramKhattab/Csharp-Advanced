namespace C42_G04_ADV04
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        private int salesTarget;

        public bool CheckTarget(int Quota)
        {
            salesTarget = Quota;
            return AchievedTarget >= salesTarget;
        }

        public override void EndOfYearOperation()
        {
            if (!CheckTarget(salesTarget))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.FailedToAchieveTarget
                });
            }
        }
    }
}