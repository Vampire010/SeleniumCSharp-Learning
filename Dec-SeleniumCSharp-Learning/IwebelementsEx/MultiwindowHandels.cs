using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_SeleniumCSharp_Learning.IwebelementsEx
{
    public class MultiwindowHandels
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.snapdeal.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [Test]
        public void indowSwitch()
        {
            String parentWinId = driver.CurrentWindowHandle.ToString();
            Console.Write("parentWinId: " + parentWinId);
            IWebElement productLink1 = driver.FindElement(By.XPath("//a[@href=\"https://www.snapdeal.com/product/bhawna-collection-loard-shiv-trishul/672311651336\"]"));
            IWebElement productLink2 = driver.FindElement(By.XPath("//a[@href=\"https://www.snapdeal.com/product/veirdo-green-half-sleeve-tshirt/639827458615\"]"));
            productLink1.Click();
            Thread.Sleep(3000);

            //switch to child to parent window
            driver.SwitchTo().Window(parentWinId);

            Thread.Sleep(5000);

            //switch to parent to child window
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(5000);

            //switch to child to parent window
            driver.SwitchTo().Window(parentWinId);
            Thread.Sleep(3000);

            productLink2.Click();

            Thread.Sleep(3000);
            //switch to child to parent window
            driver.SwitchTo().Window(parentWinId);
            Thread.Sleep(3000);

            //switch to parent to child window
            driver.SwitchTo().Window(driver.WindowHandles[2]).Close();
            Thread.Sleep(5000);
        }


        [TearDown]
        public void teardown()
        {
            driver.Quit();
        }
    }
}
