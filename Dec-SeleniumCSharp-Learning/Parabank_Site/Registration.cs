using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_SeleniumCSharp_Learning.Parabank_Site
{
    public class Registration
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [Test]
        public void Test1()
        {
            //IWebElement clkRegister = driver.FindElement(By.LinkText("Register"));
            IWebElement clkRegisterlnk = driver.FindElement(By.PartialLinkText("Regis"));
            clkRegisterlnk.Click();
            
            IWebElement firstNameTbox = driver.FindElement(By.Id("customer.firstName"));            
            firstNameTbox.SendKeys("Laxman");
            
            IWebElement lastnameTbox = driver.FindElement(By.Id("customer.lastName"));
            lastnameTbox.SendKeys("Guru");
           
            IWebElement addressTbox = driver.FindElement(By.Name("customer.address.street"));
            addressTbox.SendKeys("24, 7th Street Hill Road");
           
            IWebElement cityTbox = driver.FindElement(By.Name("customer.address.city"));
            cityTbox.SendKeys("Bangalore");

            IWebElement stateTbox = driver.FindElement(By.CssSelector("#customer\\.address\\.state"));
            stateTbox.SendKeys("Karnataka");

            IWebElement zipCodeTbox = driver.FindElement(By.CssSelector("#customer\\.address\\.zipCode"));
            zipCodeTbox.SendKeys("560025");

            //Relative XPATH
            IWebElement phoneTbox = driver.FindElement(By.XPath("//*[@id=\"customer.phoneNumber\"]"));
            phoneTbox.SendKeys("9876432101");

            //Absolute XPATH
            IWebElement ssnTbox = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/form/table/tbody/tr[8]/td[2]/input"));
            ssnTbox.SendKeys("112106541");

            IWebElement usernameTbox = driver.FindElement(By.XPath("//input[@name=\"customer.username\"]"));
            usernameTbox.SendKeys("Laxman007");

            IWebElement passwordTbox = driver.FindElement(By.XPath("//input[@id=\"customer.password\" or @name=\"customer.password\"]\r\n"));
            passwordTbox.SendKeys("Laxman1234");

            IWebElement confirmPassTbox = driver.FindElement(By.XPath("//input[@id=\"repeatedPassword\" and @name=\"repeatedPassword\"]\r\n"));
            confirmPassTbox.SendKeys("Laxman1234");

            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@id=\"repeatedPassword\" and @name=\"repeatedPassword\"]\r\n"));
            submitBtn.Submit();

        }

        [TearDown]
        public void teardown()
        {
            Thread.Sleep(5000);

            driver.Close();
        }
    }
}
