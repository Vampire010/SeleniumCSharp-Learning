using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Dec_SeleniumCSharp_Learning.Browser_Launch
{
    [TestFixture]
    public class ChromeBrowserlaunch
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            
            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(3000);
            driver.Navigate().Refresh();
            //driver.Navigate().Back();
           // Thread.Sleep(3000);

          //  driver.Navigate().Forward();
        }

        [Test]
        public void Test1()
        {

            driver.FindElement(By.Name("q")).SendKeys("Selenium Dev");
           // Thread.Sleep(3000);
         //   driver.FindElement(By.Name("q")).Clear();

            string ExpectedPageTitle = "Google";
            string ActualpageTitle = driver.Title;
            Console.WriteLine(ActualpageTitle);

            // Assert.That(ExpectedPageTitle, Is.EqualTo(ActualpageTitle));

            //Assert.That(ExpectedPageTitle, Is.Not.EqualTo(ActualpageTitle));


            string pagesrc = driver.PageSource;
            Console.WriteLine(pagesrc);

        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
