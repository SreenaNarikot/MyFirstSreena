using MyFirstSreena.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSreena.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //Identify the element create employee and click
            IWebElement createEmployeebutton = driver.FindElement(By.XPath("/html/body/div[4]/p/a"));
            createEmployeebutton.Click();

            // Identify the element Name and enter value
            IWebElement employeeName = driver.FindElement(By.Id("Name"));
            employeeName.SendKeys("Dora");

            //Identify the element Username and enter value
            IWebElement employeeUsername = driver.FindElement(By.Id("Username"));
            employeeUsername.SendKeys("UserDora");

            //Identify the element Contact and enter value
            IWebElement employeeContact = driver.FindElement(By.Id("ContactDisplay"));
            employeeContact.SendKeys("12312323");

            //Identify the element Password and enter the value
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Dora-1234");

            //Identify the element RetypePassword  and enter the value
            IWebElement reTypePassword = driver.FindElement(By.Id("RetypePassword"));
            reTypePassword.SendKeys("Dora-1234");

            //Find the element Checkbox and check 
            IWebElement checkBoxIsAdmin = driver.FindElement(By.Id("IsAdmin"));
            checkBoxIsAdmin.Click();

            //Find the element Save button and click
            IWebElement employeeSaveButton = driver.FindElement(By.Id("SaveButton"));
            employeeSaveButton.Click();
            Thread.Sleep(3000);

            //check if the created employee record is saved

            //Identify and Click on the link  back to list 
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "Xpath", "//*[@id='usersGrid']/div[4]/a[4]/span", 5);

            //Identify the lastpage button and click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();


            //Identify the Last Created Record
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]", 6);

            IWebElement lastEmployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement lastEmployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(3000);

            //Assertion for matching record
            Assert.That(lastEmployeeName.Text == "Dora", "The Name do not match");
            Assert.That(lastEmployeeUserName.Text == "UserDora", "The UserNames do not match");


        }

        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Find the element Lastpage button and click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            lastPageButton.Click();
            Thread.Sleep(3000);

            //Identify last record and check if the record exists to edit
            IWebElement lastEmployeenametoEdit = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);
            

            if (lastEmployeenametoEdit.Text == "Dora" )
            {
                //Find the element edit button and click
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to edit not Found");
            }


            //Find the element 
            // Identify the element Name and enter value
            IWebElement editemployeeName = driver.FindElement(By.Id("Name"));
            editemployeeName.Clear();
            editemployeeName.SendKeys("EditDora");

            //Identify the element Username and enter value
            IWebElement editemployeeUsername = driver.FindElement(By.Id("Username"));
            editemployeeUsername.Clear();
            editemployeeUsername.SendKeys("EditUserDora");

            //Identify the element Contact and enter value
            IWebElement editemployeeContact = driver.FindElement(By.Id("ContactDisplay"));
            editemployeeContact.Clear();
            editemployeeContact.SendKeys("12312312");

            //Identify the element Password and enter the value
            IWebElement editpassword = driver.FindElement(By.Id("Password"));
            editpassword.Clear();
            editpassword.SendKeys("Dora-123412");

            //Identify the element RetypePassword  and enter the value
            IWebElement editreTypePassword = driver.FindElement(By.Id("RetypePassword"));
            editreTypePassword.Clear();
            editreTypePassword.SendKeys("Dora-123412");

            //Find the element Checkbox and check 
            //IWebElement editcheckBoxIsAdmin = driver.FindElement(By.Id("IsAdmin"));
            //editcheckBoxIsAdmin.Click();

            //Find the element Save button and click
            IWebElement editemployeeSaveButton = driver.FindElement(By.Id("SaveButton"));
            editemployeeSaveButton.Click();
            Thread.Sleep(3000);

            //Identify and Click on the link  back to list 
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Thread.Sleep(3000);

            //Identify the lastpage button and click
            IWebElement lastPageButtonedit = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButtonedit.Click();

            //Identify the Last edited Record
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]", 6);

            IWebElement editedlastEmployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedlastEmployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(6000);

            //Assertion for matching record
            Assert.That(editedlastEmployeeName.Text == "EditDora", "The Name do not match");
            Assert.That(editedlastEmployeeUserName.Text == "EditUserDora", "The UserNames do not match");


        }
        public void DeleteEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Find the element Lastpage button and click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            lastPageButton.Click();
            Thread.Sleep(3000);

            //Identify last record and check if the record exists to edit
            IWebElement lastEmployeenametoDelete = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);


            if (lastEmployeenametoDelete.Text == "EditDora")
            {
                //Find the element edit button and click
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(3000);

                //Switching to Alert
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to delete not Found");
            }
            //assert that last record has been deleted         

            // Identify the last record and check if it is deleted
            
            IWebElement lastName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[3]/td[1]"));
            Assert.That((lastName.Text != "EditDora"), "Record not deleted,Test Failed");


        }

    }
}
