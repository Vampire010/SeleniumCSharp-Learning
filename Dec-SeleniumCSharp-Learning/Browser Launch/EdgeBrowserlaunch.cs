using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace Dec_SeleniumCSharp_Learning.Browser_Launch
{
    [TestFixture]
    public class EdgeBrowserlaunch
    {
        public static IWebDriver driver;

        [SetUp] 
        public void Setup()
        {

            //calling browser driver
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }

       // [Test]
        public void Test1()
        {

           IWebElement textEle = driver.FindElement(By.XPath("//*[@id=\"td-cover-block-0\"]/div/div/div/div/h1"));

            string Text = textEle.Text;
            Console.WriteLine(Text);
        }

        [TearDown]
        public void teardown()
        {
            //Thread.Sleep(2000);
            driver.Close();
        }
    }
}
