using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_SeleniumCSharp_Learning.Frames_Ex
{
    public class IframeExample
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/giris/source/repos/SeleniumCSharp-Learning/Dec-SeleniumCSharp-Learning/Frames_Ex/mainpanel.html");

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            IWebElement frme1 = driver.FindElement(By.Id("Frame1"));
            IWebElement frme2 = driver.FindElement(By.Id("Frame2"));
            IWebElement frme3 = driver.FindElement(By.XPath("//*[@id=\"Frame3\"]"));

            driver.SwitchTo().Frame(frme1);
            IWebElement getTextofEle1 = driver.FindElement(By.XPath("//*[@id=\"mw-content-text\"]/div[1]/div/div[1]/div/p[1]/strong"));
            Console.WriteLine(getTextofEle1.Text);

            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(1);

            IWebElement getTextofEle2 = driver.FindElement(By.XPath("//*[@id=\"firstHeading\"]/p"));
            Console.WriteLine(getTextofEle2.Text);

            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(frme3);
            IWebElement getTextofEle3 = driver.FindElement(By.XPath("//*[@id=\"Meta-Wiki\"]"));
            Console.WriteLine(getTextofEle3.Text);
            Thread.Sleep(5000);

        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
