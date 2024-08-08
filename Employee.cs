using System;

namespace C42_G04_ADV04
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        private DateTime birthDate;
        private int vacationStock;

        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int VacationStock
        {
            get { return vacationStock; }
            set { vacationStock = value; }
        }

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int days = (int)(To - From).TotalDays + 1;
            if (days <= VacationStock)
            {
                VacationStock -= days;
                return true;
            }
            return false;
        }

        public virtual void EndOfYearOperation()
        {
            if (VacationStock < 0 || (DateTime.Now.Year - BirthDate.Year) > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = VacationStock < 0 ? LayOffCause.NegativeVacationStock : LayOffCause.AgeOver60
                });
            }
        }
    }
}