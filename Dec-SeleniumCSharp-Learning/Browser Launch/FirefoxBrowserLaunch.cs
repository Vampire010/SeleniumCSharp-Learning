using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Dec_SeleniumCSharp_Learning.Browser_Launch
{
    [TestFixture]
    public class FirefoxBrowserLaunch
    {
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var geckoDriver = @"C:\\Users\\giris\\source\\repos\\SeleniumCSharp-Learning\\Dec-SeleniumCSharp-Learning\\Drivers\\geckodriver.exe";
            //calling browser driver
            driver = new FirefoxDriver(geckoDriver);
            
            driver.Navigate().GoToUrl("https://www.snapdeal.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

      //  [Test]
        public void Test1()
        {   

            driver.FindElement(By.XPath("/html/body/div[10]/section/div[4]/section/div[2]/div[1]/div/div[5]/a/div[3]/div[1]")).Click();
        }

        [TearDown]
        public void teardown()
        {
            Thread.Sleep(5000);
           //  driver.Close();
         //   driver.Quit();
        }
    }
}
