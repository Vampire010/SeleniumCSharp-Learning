using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_SeleniumCSharp_Learning.IwebelementsEx
{
    public class MultiSelectDropDownHandle
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/giris/source/repos/SeleniumCSharp-Learning/Dec-SeleniumCSharp-Learning/Html%20code/MultiSelectDropdown.html");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

        }

        [Test]
        public void Test1()
        {
            IWebElement dropdonwPath = driver.FindElement(By.Id("cars"));
            Thread.Sleep(3000);

            SelectElement dropdown = new SelectElement(dropdonwPath);
            dropdown.SelectByIndex(0);
            dropdown.SelectByText("Saab");
            dropdown.SelectByValue("opel");

            Thread.Sleep(5000);
            dropdown.DeselectByText("Saab");
            dropdown.DeselectByValue("opel");
            dropdown.DeselectByIndex(0);

            Thread.Sleep(5000);
            dropdown.SelectByIndex(0);
            dropdown.SelectByText("Saab");
            dropdown.SelectByValue("opel");

            Thread.Sleep(5000);
            dropdown.DeselectAll();
        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
