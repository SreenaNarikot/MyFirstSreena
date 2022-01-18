using MyFirstSreena.Pages;
using MyFirstSreena.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSreena.Tests 
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {

        [Test, Order(1), Description("Check if the user able to create Employee record with valid data")]
        public void createEmployee_Test()
        {
            //Homepage Object initialisation and Definition
            HomePage homepage = new HomePage();
            homepage.GoToEmployeePage(driver);

            //EmployeePage object initialisation and definition 
            EmployeePage employeePage = new EmployeePage();
            employeePage.CreateEmployee(driver);

        }

        [Test, Order(2), Description("Check if the user able to edit Employee record with valid data")]
        public void editEmployee_Test()
        {
            //Homepage Object initialisation and Definition
            HomePage homepage = new HomePage();
            homepage.GoToEmployeePage(driver);

            //Edit Employee
            //EmployeePage employeePage = new EmployeePage();
            //employeePage.EditEmployee(driver);

        }
        //[Test, Order(3), Description("Check if the user able to delete Employee record with valid data")]

        //public void deleteEmployee_test()
        //{
        //    //Homepage Object initialisation and Definition
        //    HomePage homepage = new HomePage();
        //    homepage.GoToEmployeePage(driver);

        //    //delete employee
        //    EmployeePage employeePage = new EmployeePage();
        //    employeePage.DeleteEmployee(driver);    

        //}
    }
}
