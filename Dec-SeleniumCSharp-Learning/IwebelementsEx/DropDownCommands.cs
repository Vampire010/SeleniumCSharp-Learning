using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Dec_SeleniumCSharp_Learning.IwebelementsEx
{
    public class DropDownCommands
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            Thread.Sleep(3000);

        }

         [Test]
        public void Test1()
        {

            IWebElement dropdonwPath = driver.FindElement(By.XPath("//*[@id=\"searchDropdownBox\"]"));

            SelectElement dropdown = new SelectElement(dropdonwPath);
            //dropdown.SelectByText("Apps & Games");

            //dropdown.SelectByValue("search-alias=hpc");

            dropdown.SelectByIndex(1);

            Thread.Sleep(3000);



        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
