using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyFirstVS
{
    class Program
    {
        static void Main(string[] args)
        {
            // To Open a New Chrome Browser 
            IWebDriver driver = new ChromeDriver();

            //To maximise the  Chrome browser
            driver.Manage().Window.Maximize();

            // To navigate to the URL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify the textbox usernmname and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //Identify password textbox  and enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //Click on LoginButton
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //Checking whether user logged in successfully
            IWebElement helloUser = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloUser.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Succesfully,Test Passed");
            }
            else
            {
                Console.WriteLine("Login Failed,Test Failed");
            }
            //time  and Material
            IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropdown.Click();
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialOption.Click();

            //Create NEW button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            //Select material from tycode dropdown
            IWebElement materialButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            materialButton.Click();

            //Identify code textbox and enter value
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Code01");

            //Identify description Text box and enter the value
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Material01");

            //Identify Price text box and enter the value
            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            //PriceTextbox Overlapping
            IWebElement priceTextBoxone = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/label"));
            priceTextBoxone.Click();
            //priceTextBox.SendKeys("555");

            //Identify save button and click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Checking for updated record
            //1.Click on to the last page button
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();

            //2.Checking the record is present
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord.Text == "Code01")
            {
                Console.WriteLine("Material Record created successfully,Test Passed");
            }
            else
            {
                Console.WriteLine("Record not created ,Test failed");
            }






        }
    }
}
