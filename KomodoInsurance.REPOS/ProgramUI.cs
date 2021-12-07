using KomodoInsurance.POCO;
using KomodoInsurance01_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceTeamTracker.UI
{
    public class ProgramUI
    {
        private readonly EmployeeRepo _employeeRepo = new EmployeeRepo();

        public void Run()
        {
            RunApplication();
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the Komodo Insurance Employee Management System\n" +
                "1. Create New Employee\n" +
                "2. View All Employees\n" +
                "3. View a single Employee\n" +
                "4. Update an Existing Employee\n" +
                "5. Delete an Employee\n" +
                "100. Close Application");
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Menu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateEmployee();
                        break;
                    case "2":
                        ViewAllEmployees();
                        break;
                    case "3":
                        ViewSingleEmployee();
                        break;
                    case "4":
                        UpdateEmployee();
                        break;
                    case "5":
                        DeleteEmployee();
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        private void UpdateEmployee()
        {
            throw new NotImplementedException();
        }

        private void ViewSingleEmployee()
        {
            Console.Clear();

            List<Employee> listOfSingleEmployee = _employeeRepo.GetEmployees();

            foreach (var employee in listOfSingleEmployee)
            {
                DisplayPlayerInfo(employee);
            }
            Console.ReadLine();
        }

        private void ViewAllEmployees()
        {
            Console.Clear();

            List<Employee> listOfAllEmployees = _employeeRepo.GetEmployees();

            foreach (var employee in listOfAllEmployees)
            {
                DisplayPlayerInfo(employee);
            }
            Console.ReadLine();
        }

        private void DisplayPlayerInfo(Employee employee)
        {
            Console.WriteLine($"{employee.Id}\n" +
                $"{employee.FirstName}\n" +
                $"{employee.LastName}\n" +
                $"{employee.EmployeeTeam}");
            Console.WriteLine("*************************************");
        }

        private void CreateEmployee()
        {
            Console.Clear();

            Console.WriteLine("Please input the employee's first name: ");
            string userInputFirstName = Console.ReadLine();

            Console.WriteLine("Please input the employee's last name: ");
            string userInputLastName = Console.ReadLine();

            Console.WriteLine("Please input Employees' Team:\n" +
                "1. Developer\n" +
                "2. DevTeam");
            int userInputEmployeeType = int.Parse(Console.ReadLine());

            EmployeeType employeeType = (EmployeeType) userInputEmployeeType;

            Employee employeeToBeAddedToDataBase = new Employee(userInputFirstName, userInputLastName, employeeType);

            bool isSuccessful = _employeeRepo.CreateEmployee(employeeToBeAddedToDataBase);
            if (isSuccessful)
            {
                Console.WriteLine($"{userInputFirstName} was successfully added to the system!");
            }
            else
            {
                Console.WriteLine($"{userInputFirstName} was not added to the database!");
            }
        }
    }
}
