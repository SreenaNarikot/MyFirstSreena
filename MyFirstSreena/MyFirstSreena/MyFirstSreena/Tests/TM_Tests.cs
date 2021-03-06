using MyFirstSreena.Pages;
using MyFirstSreena.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyFirstVS
{
    [TestFixture]
    [Parallelizable]
    class TM_Tests : CommonDriver
    { 

        [Test, Order(1), Description("Check if the user is able to create material record with valid data")]
        public void CreateTM_Test()
        {
        //Home Page initialization and definition
        HomePage homePage = new HomePage();
        homePage.GoToTMPage(driver);

        //TM Page object initialization and definition
        TM_Page tmPage = new TM_Page();
            tmPage.CreateTM(driver);
        }
        [Test, Order(2), Description("Check if the user is able to edit material record with valid data")]
        public void EditTM_Test()
        {
            //Home Page initialization and definition
            HomePage homePage = new HomePage();
            homePage.GoToTMPage(driver);

            //TM Page Edit
            TM_Page tmPage = new TM_Page();
            tmPage.EditTM(driver);

        }
        [Test, Order(3), Description("Check if the user is able to delete the edited  materialrecord")]
        public void DeleteTM_Test()
        {
            //Home Page initialization and definition
            HomePage homePage = new HomePage();
            homePage.GoToTMPage(driver);
            //TM delete
            TM_Page tmPage = new TM_Page();
            tmPage.DeleteTM(driver);

        }
        


    }
}
