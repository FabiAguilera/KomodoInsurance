using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCO
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string firstName, string lastName, EmployeeType employeeTeam)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeTeam = employeeTeam;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeTeam { get; set; }
        public int Id { get; set; }
    }
}
