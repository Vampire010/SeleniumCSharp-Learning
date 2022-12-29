using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dec_SeleniumCSharp_Learning.Browser_Launch
{
    public class printTextOnpage
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
            Thread.Sleep(3000);
            driver.Navigate().Refresh();
           
        }

        [Test]
        public void Test1()
        {

           var links = driver.FindElements(By.TagName("a"));
          
            foreach(var Allinks in links)
            {

               // String urltext = Allinks.Text;
                Console.WriteLine(Allinks.GetAttribute("href"));
            }

        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
