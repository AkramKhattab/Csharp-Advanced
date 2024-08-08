using System;

namespace C42_G04_ADV04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Employee employee1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1980, 1, 1), VacationStock = 10 };
            Employee employee2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1960, 1, 1), VacationStock = -5 };
            SalesPerson salesPerson = new SalesPerson { EmployeeID = 3, BirthDate = new DateTime(1985, 1, 1), VacationStock = 15, AchievedTarget = 80 };
            BoardMember boardMember = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(1970, 1, 1) };

            Department department = new Department { DeptID = 1, DeptName = "IT Department" };
            Club club = new Club { ClubID = 1, ClubName = "Company Sports Club" };

            // Add employees to department and club
            department.AddStaff(employee1);
            department.AddStaff(employee2);
            department.AddStaff(salesPerson);
            department.AddStaff(boardMember);


            club.AddMember(employee1);
            club.AddMember(employee2);
            club.AddMember(salesPerson);
            club.AddMember(boardMember);

            Console.WriteLine("End of Year Operations:\n");

            // Perform end of year operations
            employee1.EndOfYearOperation();
            employee2.EndOfYearOperation();
            salesPerson.EndOfYearOperation();
            boardMember.EndOfYearOperation();

            // Demonstrate SalesPerson failing to meet target
            salesPerson.CheckTarget(100);
            salesPerson.EndOfYearOperation();

            // Demonstrate BoardMember resignation
            boardMember.Resign();

            Console.WriteLine("\nVacation Requests:\n");

            // Demonstrate vacation requests
            Console.WriteLine($"Employee1 vacation request: {employee1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(5))}");
            Console.WriteLine($"Employee2 vacation request: {employee2.RequestVacation(DateTime.Now, DateTime.Now.AddDays(1))}");

            Console.ReadLine();
        }
    }
}