using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_SeleniumCSharp_Learning.IwebelementsEx
{
    public class SelectedEx
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///D:/Manual%20Testing%20Notes-20221205T232832Z-001/Manual%20Testing%20Notes/webiste/registration/index.html");
           

        }

        [Test]
        public void Test1()
        {

            IWebElement maleRadioBtn = driver.FindElement(By.XPath("/html/body/form/fieldset[3]/p[1]/input[1]"));

            Boolean rdbtnResult = maleRadioBtn.Selected;

            Console.WriteLine(" is maleRadioBtn is Checked ? " + rdbtnResult);    

            Thread.Sleep(5000);
            if(rdbtnResult == false ) 
            {

                maleRadioBtn.Click();
                Console.WriteLine(" is maleRadioBtn is Checked ? " + maleRadioBtn.Selected);

            }
            Thread.Sleep(5000);

            Console.WriteLine("Size of a Window: " + driver.Manage().Window.Size);



        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
