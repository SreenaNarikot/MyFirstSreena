using MyFirstSreena.Pages; 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyFirstVS
{
    class TM_Tests
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            //Login page object initialisation and definition
            LoginPage loginPage = new LoginPage();
            loginPage.loginSteps(driver);

            //Home Page initialization and definition
            HomePage homePage = new HomePage();
            homePage.GoToTMPage(driver);

            //TM Page object initialization and definition
            TM_Page tmPage = new TM_Page();
            tmPage.CreateTM(driver);

            //TM Page Edit
            tmPage.EditTM(driver);

            //TM delete
            tmPage.DeleteTM(driver);


            

            
            







        }
    }
}
