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

        }
        public string GetEmployeeName(IWebDriver driver)
        {
            IWebElement lastEmployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return lastEmployeeName.Text;

        }

        public string GetUserName(IWebDriver driver)
        {
            IWebElement lastEmployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return lastEmployeeUserName.Text;
        }

        public void EditEmployee(IWebDriver driver , string employeename, string username,string contact, string password, string retypepassword)
        {
            Thread.Sleep(2000);
            //Find the element Lastpage button and click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            lastPageButton.Click();
            Thread.Sleep(3000);

            //Identify last record and check if the record exists to edit
            IWebElement lastEmployeenametoEdit = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);


            //if (lastEmployeenametoEdit.Text == "Dora" )
            //{
            //    //Find the element edit button and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);
            //}
            //else
            //{
            //   Assert.Fail("Record to edit not Found");
            //}


            //Find the element 
            // Identify the element Name and enter value
            IWebElement editemployeeName = driver.FindElement(By.Id("Name"));
            editemployeeName.Clear();
            editemployeeName.SendKeys(employeename);

            //Identify the element Username and enter value
            IWebElement editemployeeUsername = driver.FindElement(By.Id("Username"));
            editemployeeUsername.Clear();
            editemployeeUsername.SendKeys(username);

            //Identify the element Contact and enter value
            IWebElement editemployeeContact = driver.FindElement(By.Id("ContactDisplay"));
            editemployeeContact.Clear();
            editemployeeContact.SendKeys(contact);

            //Identify the element Password and enter the value
            IWebElement editpassword = driver.FindElement(By.Id("Password"));
            editpassword.Clear();
            editpassword.SendKeys(password);

            //Identify the element RetypePassword  and enter the value
            IWebElement editreTypePassword = driver.FindElement(By.Id("RetypePassword"));
            editreTypePassword.Clear();
            editreTypePassword.SendKeys(retypepassword);

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

        }
        public string GetEditedEmployeeName(IWebDriver driver)
        {
            IWebElement editedlastEmployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedlastEmployeeName.Text;
        }
        public string GetEditedUsername(IWebDriver driver)
        {
            IWebElement editedlastEmployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            Thread.Sleep(3000);
            return editedlastEmployeeUserName.Text;

        }
        public void DeleteEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Find the element Lastpage button and click
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]"));
            lastPageButton.Click();

            //Identify last record and check if the record exists to edit
            Thread.Sleep(3000);
            IWebElement lastEmployeenametoDelete = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

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
            
        }
        public string Getlastemployeename(IWebDriver driver)
        {
            IWebElement lastempName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return lastempName.Text;

        }

    }
}
