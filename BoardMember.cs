namespace C42_G04_ADV04
{
    public class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs
            {
                Cause = LayOffCause.Resignation
            });
        }

        public override void EndOfYearOperation()
        {
        }
    }
}