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
    public class Tester
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/interactions/alerts/");
            Thread.Sleep(3000);

        }

        [Test]
        public void AlertBoxTest()
        {
            IWebElement exampleAlert = driver.FindElement(By.XPath("/html/body/div/div[1]/div/main/div/p[2]/a"));
            exampleAlert.Click();
            Thread.Sleep(3000);
            IAlert alrtBox = driver.SwitchTo().Alert();
            alrtBox.Accept();
            Thread.Sleep(3000);
        }
        [Test]
        public void ConfirmBoxTest()
        {
            IWebElement exampleConfirm = driver.FindElement(By.XPath("/html/body/div/div[1]/div/main/div/p[4]/a"));
            exampleConfirm.Click();
            Thread.Sleep(3000);
            IAlert alrtBox = driver.SwitchTo().Alert();
            alrtBox.Accept();
            Thread.Sleep(3000);
        }

        [Test]
        public void PromptBoxTest()
        {
            IWebElement exampleprompt = driver.FindElement(By.XPath("/html/body/div/div[1]/div/main/div/p[6]/a"));
            exampleprompt.Click();
            Thread.Sleep(3000);
            IAlert alrtBox = driver.SwitchTo().Alert();
            alrtBox.SendKeys("Selenium Dev");
            alrtBox.Accept();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void teardown()
        {
            driver.Quit();
        }
    }
}
