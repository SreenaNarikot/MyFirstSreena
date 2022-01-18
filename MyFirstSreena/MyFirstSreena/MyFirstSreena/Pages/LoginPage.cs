using NUnit.Framework;
using OpenQA.Selenium;

namespace MyFirstSreena.Pages
{
    public class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {
            

            //To maximise the  Chrome browser
            driver.Manage().Window.Maximize();

            // To navigate to the URL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {
                //identify the textbox usernmname and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                //Identify password textbox  and enter valid password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                //Click on LoginButton
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();


            }
            catch(Exception ex)
            {
                Assert.Fail("TurnUP Portal login page did not lauch",ex.Message);
            }
            //Identifying if the user logged in successfully

            //Find the hello hari textbox
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul"));
            Thread.Sleep(3000);

            Assert.That((helloHari.Text == "Hello hari!"), "User login failed!");

            //if (helloHari.Text == "Hello hari!") 
            //{
            //    Assert.Pass("Logged in succesfully");
            //}
            //else
            //{
            //    Assert.Fail("User Login failed");
            //}

           


        }

    }
}
