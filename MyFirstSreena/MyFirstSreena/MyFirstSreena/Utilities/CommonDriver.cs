using MyFirstSreena.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSreena.Utilities
{
   public class CommonDriver
   {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void loginfunction()
        {

            // To Open a New Chrome Browser 
           driver = new ChromeDriver();

        //LoginPage Object initialisation and defintion
        LoginPage loginPage = new LoginPage();
        loginPage.loginSteps(driver);

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
