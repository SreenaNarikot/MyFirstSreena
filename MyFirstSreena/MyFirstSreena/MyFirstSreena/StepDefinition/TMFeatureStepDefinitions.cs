using MyFirstSreena.Pages;
using MyFirstSreena.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MyFirstSreena
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPage = new LoginPage();
        HomePage homePage = new HomePage();
        TM_Page tmPage = new TM_Page();

        [Given(@"\[logged in to Turnup Portal]")]
        public void GivenLoggedInToTurnupPortal()
        {
            // To Open a New Chrome Browser 
            driver = new ChromeDriver();
            loginPage.loginSteps(driver);
        }

        [Given(@"\[Navigate to TM]")]
        public void GivenNavigateToTM()
        {
            //Home Page initialization and definition
            homePage.GoToTMPage(driver);
        }

        [When(@"\[I create TM Record]")]
        public void WhenICreateTMRecord()
        {
            tmPage.CreateTM(driver);
        }

        [Then(@"\[Record created Successfully]")]
        public void ThenRecordCreatedSuccessfully()
        {
            string actualcode = tmPage.GetCode(driver);
            Assert.That(actualcode == "myCode01", "Actual Code and expected code do not match");
        }

        [When(@"\[I edit TM Record]")]
        public void WhenIEditTMRecord()
        {
            tmPage.EditTM(driver);
        }

        [Then(@"\[Record edited Successfully]")]
        public void ThenRecordEditedSuccessfully()
        {
            string editedCode = tmPage.GetCode(driver);
            Assert.That(editedCode == "editcode01","Edited Code and Expected code do not match");

        }

        [When(@"\[I delete TM Record]")]
        public void WhenIDeleteTMRecord()
        {
           tmPage.DeleteTM(driver);
        }

        [Then(@"\[Record deleted Successfully]")]
        public void ThenRecordDeletedSuccessfully()
        {
            string lastRecordFound = tmPage.deletedcode(driver);
            Assert.That(lastRecordFound != "edited01", "Record not deleted");
        }
    }
}
