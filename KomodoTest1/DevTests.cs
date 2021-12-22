using KomodoInsurance.POCO;
using KomodoInsurance01_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoTest1
{
    
    [TestClass] // anotation
    public class DevTests
    {
        Employee _employee = new Employee();
        EmployeeRepo _employeeRepo = new EmployeeRepo();
        [TestMethod] // anotation ----- we know this because they are in square brackets
        public void CreateEmployee_ValidEmployee_ReturnsTrue() // all test methods will be void because it will not return anyhting, it is just a check
        {
            //Arrange - organizing/setting test method to call upon method

            _employee.Id = 0;

            //Act
            bool employeeCreated = _employeeRepo.CreateEmployee(_employee);

            //Assert
            Assert.IsTrue(employeeCreated);

        }

        public void GetEmployees()
        {
           
        }

        public void GetEmployeeById()
        {

        }

        public void UpdateEmployee_ValidInfo_ReturnsTrue()
        {
            // arrange
            
            _employee.newEmployeeData = 0;

            // act
            bool employeeUpdated = _employeeRepo.UpdateEmployee(_employee);
            // assert
            Assert.IsTrue(employeeUpdated);
        }

        public void DeleteEmployee()
        {

        }


    }
}
