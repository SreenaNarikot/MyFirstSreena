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
    public class TM_Page
    {
        public void CreateTM(IWebDriver driver)
        {
            // find the element Create NEW button and click
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
            Thread.Sleep(3000);

            //Checking for created record
            //1.Click on to the last page button
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();

            //2.Checking the record is present
            IWebElement lastCodeFound = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            //option 1
            Assert.That(lastCodeFound.Text == "myCode01", "The Code do not match");

            ////Option 2
            //if (lastCodeFound.Text == "myCode01")
            //{

            //    // Console.WriteLine("Material Record created successfully,Test Passed");
            //    Assert.Pass("Material Record created successfully,Test Passed");

            //}
            //else
            //{

            //    //Console.WriteLine("Record not created ,Test failed");

            //    Assert.Fail("Record not created ,Test failed");

            //}

        }

      
        public void EditTM(IWebDriver driver)

        {
            Thread.Sleep(3000);
            //Click and go to last page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastPageButton.Click();

            IWebElement lastCodeToEdit= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if(lastCodeToEdit.Text == "myCode01")
            {
                // Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }

            else
            {
                Assert.Fail("Record Could not found to edit");
            }


           

            //Edit current Code
            IWebElement editcode = driver.FindElement(By.Id("Code"));
            editcode.Clear();
            editcode.SendKeys("editcode01");

            //Edit Current Description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));

            editDescription.Clear();
            editDescription.SendKeys("EditDescrption01");
            Thread.Sleep(2000);
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span", 5);

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
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);


            //Checking for edited and updated record
            //1.Click on to the last page button
            IWebElement golastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            golastPageButton.Click();
            Thread.Sleep(2000);
            

            // 2.Checking the edited record is present
            IWebElement editedlastCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            if (editedlastCode.Text == "editcode01")
            {
                //Console.WriteLine("Material Record Edited successfully,Test Passed");
                Assert.Pass("Material Record Edited successfully,Test Passed");
            }
            else
            {
                //Console.WriteLine(" Edit Record not created ,Test failed");
                Assert.Fail(" Edit Record not created ,Test failed");

            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //Delete Button

            //findlast page button and click
            IWebElement lastPagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastPagebutton.Click();

            //Find the edited Record
            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if(findEditedRecord.Text == "editcode01")
            {
                //Finding delete button of last Record
                IWebElement lastdeletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                lastdeletebutton.Click();


                //Switching to Alert
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to delete not found");
            }

            

            //Assert that last record has been deleted
            //Go to last page
            IWebElement lastPagego = driver.FindElement((By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")));
            lastPagego.Click();
            Thread.Sleep(5000);

            // Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[1]", 5);

            IWebElement checkLastCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[1]"));
            Assert.That(checkLastCode.Text != "editcode01", "Record not deleted ,Test failed!");

            //if (checkLastCode.Text == "editcode01")
            //{
            //    //Console.WriteLine("Record not deleted ,Test failed");
            //    Assert.Pass("Record not deleted ,Test failed");
            //}  
            //else
            //{

            //    //Console.WriteLine("Record Deleted,Test Passed");
            //    Assert.Fail("Record Deleted,Test Passed");
            //}


        }

    }
}
