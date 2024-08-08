using System;
using System.Collections.Generic;

namespace C42_G04_ADV04
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee && e.Cause == LayOffCause.NegativeVacationStock)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from club {ClubName} due to negative vacation stock.");
            }
        }
    }
}