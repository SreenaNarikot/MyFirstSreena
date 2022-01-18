using MyFirstSreena.Pages;
using MyFirstSreena.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MyFirstSreena
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommonDriver
    {
        HomePage homepage = new HomePage();
        EmployeePage employeePage = new EmployeePage();

        [Given(@"\[Logged in to turnup portal]")]
        public void GivenLoggedInToTurnupPortal()
        {
            // To Open a New Chrome Browser 
            driver = new ChromeDriver();

            //LoginPage Object initialisation and defintion
            LoginPage loginPage = new LoginPage();
            loginPage.loginSteps(driver);
        }

        [Given(@"\[Naviagte to Employee]")]
        public void GivenNaviagteToEmployee()
        {
            //Homepage Object initialisation and Definition
            homepage.GoToEmployeePage(driver);
        }

        [When(@"\[I create the emplyee record]")]
        public void WhenICreateTheEmplyeeRecord()
        {
            //EmployeePage object initialisation and definition 
            employeePage.CreateEmployee(driver);

        }
        
        [Then(@"\[Employee Record created successfully]")]
        public void ThenEmployeeRecordCreatedSuccessfully()
        {
            string employeeName = employeePage.GetEmployeeName(driver);
            string employeeUserName = employeePage.GetUserName(driver);

            Assert.That(employeeName == "Dora", "Actual EmployeeName and Expected Employee Name do not match");
            Assert.That(employeeUserName == "UserDora", "Actual EmployeeName and Expected Employee Name do not match");
        }



        [When(@"\[I Edited the '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' record]")]
        public void WhenIEditedTheAndAndAndAndRecord(string p0, string p1, string p2, string p3, string p4)
        {

            employeePage.EditEmployee(driver, p0, p1, p2, p3, p4);


        }

        [Then(@"\[The record should have been updated '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)']")]
        public void ThenTheRecordShouldHaveBeenUpdatedAndAndAndAnd(string p0, string p1, string p2, string p3, string p4)
        {

            string editedemployeename = employeePage.GetEditedEmployeeName(driver);
            string editeusername = employeePage.GetEditedUsername(driver);
            Assert.That(editedemployeename == p0, "Actual employee name and expected employee name do not match");
            Assert.That(editeusername == p1, "Actual employee username and expected employee username do not match");

        }

        [When(@"\[I delete the employee record ]")]
        public void WhenIDeleteTheEmployeeRecord()
        {
            employeePage.DeleteEmployee(driver);
        }

        [Then(@"\[Employee Record with deleted successfully]")]
        public void ThenEmployeeRecordWithDeletedSuccessfully()
        {
            Thread.Sleep(2000);
            string lastemployeename = employeePage.Getlastemployeename(driver);
            Assert.That(lastemployeename != "EditDora", "Employee record has not been deleted");

        }

    }

}
