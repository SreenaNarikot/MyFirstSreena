using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSreena.Pages
{
   public class TM_Page
   {
        public void CreateTM(IWebDriver driver)
        {
            //Create NEW button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            //Select material from tycode dropdown
            IWebElement materialButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            materialButton.Click();

            //Identify code textbox and enter value
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("myCode01");

            //Identify description Text box and enter the value
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Material01");


            //Identify Price text box and enter the value      
            IWebElement priceTextBoxLabel = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            priceTextBoxLabel.Click(); //PriceTextbox Overlapping
            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.Click();
            priceTextBox.SendKeys("555");

            //Identify save button and click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Checking for updated record
            //1.Click on to the last page button
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();

            //2.Checking the record is present
            IWebElement lastRecordFound = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            if (lastRecordFound.Text == "myCode01")
            {

                Console.WriteLine("Material Record created successfully,Test Passed");

            }
            else
            {

                Console.WriteLine("Record not created ,Test failed");


            }

        }

        public void EditTM(IWebDriver driver)
        {
            // Edit Button
             IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //Edit current Code
            IWebElement editcode = driver.FindElement(By.Id("Code"));
            editcode.Clear();
            editcode.SendKeys("editcode01");

            //Edit Current Description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));

            editDescription.Clear();
            editDescription.SendKeys("EditDescrption01");
            Thread.Sleep(2000);

            //Editing current Price

            IWebElement editpriceTextBoxLabel = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            IWebElement editpriceBox = driver.FindElement(By.Id("Price"));

            editpriceTextBoxLabel.Click();
            editpriceBox.Clear();
            editpriceTextBoxLabel.Click();
            editpriceBox.SendKeys("500");

            //Find save button and click
            IWebElement editsaveButton = driver.FindElement(By.Id("SaveButton"));
            editsaveButton.Click();
            Thread.Sleep(2000);

            //Checking for edited and updated record
            //1.Click on to the last page button
            IWebElement editedlastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            editedlastPage.Click();

            // 2.Checking the edited record is present
            IWebElement editedlastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (editedlastRecord.Text == "editcode01")
            {
                Console.WriteLine("Material Record Edited successfully,Test Passed");
            }
            else
            {
                Console.WriteLine(" Edit Record not created ,Test failed");

            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            //Delete Button

            //findlast page button and click
            IWebElement lastPagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPagebutton.Click();

            //Finding Last record delete button
            IWebElement lastdeletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            lastdeletebutton.Click();

            //Switching to Alert
            driver.SwitchTo().Alert().Accept();

            //Checking if the record is deleted
            IWebElement lastPagego = driver.FindElement((By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")));
            lastPagego.Click();
            Thread.Sleep(2000);
            IWebElement checkLastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[1]"));

            if (checkLastRecord.Text == "editcode01")
            {
                Console.WriteLine("Record not deleted ,Test failed");
            }
            else
            {
                Console.WriteLine("Record Deleted,Test Passed");
            }

        }
   }
}
