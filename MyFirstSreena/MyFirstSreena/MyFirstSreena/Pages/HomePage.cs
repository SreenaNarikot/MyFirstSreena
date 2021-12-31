using MyFirstSreena.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSreena.Pages
{
   public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //time  and Material
            IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropdown.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);
           
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialOption.Click();
        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropdown.Click();
            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a", 5);

            IWebElement EmployeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EmployeeOption.Click();
            
        }

    }
}
