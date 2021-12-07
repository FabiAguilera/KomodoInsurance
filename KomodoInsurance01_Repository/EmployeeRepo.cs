using KomodoInsurance.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance01_Repository
{
    public class EmployeeRepo
    {
        private readonly List<Employee> _employee = new List<Employee>();


        private int _count = 0;

        // Create

        public bool CreateEmployee(Employee employee)
        {
            if (employee is null)
            {
                return false;
            }
            _count++;
            employee.Id = _count;
            _employee.Add(employee);
            return true;
        }


        // Read

        public List<Employee> GetEmployees()
        {
            return _employee;
        }

        public Employee GetEmployeeById(int id)
        {
            foreach(Employee employee in _employee)
            {
                if (id == employee.Id)
                {
                    return employee;
                }
            }
            return null;
        }

        // Update

        public bool UpdateEmployee(int id, Employee newEmployeeData)
        {
            Employee oldEmployeeData = GetEmployeeById(id);
            if(oldEmployeeData != null)
            {
                oldEmployeeData.Id = newEmployeeData.Id;
                oldEmployeeData.FirstName = newEmployeeData.FirstName;
                oldEmployeeData.LastName = newEmployeeData.LastName;
                oldEmployeeData.EmployeeTeam = newEmployeeData.EmployeeTeam;
                return true;
            }
            else
            {
                return false;
            }
        }

        // delete
        public bool DeleteEmployee(int id)
        {
            Employee employeeToBeRemoved = GetEmployeeById(id);
            if (employeeToBeRemoved == null)
            {
                return false;
            }
            else
            {
                _employee.Remove(employeeToBeRemoved);
                return true;
            }
        }


    }
}
