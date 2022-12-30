using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec_SeleniumCSharp_Learning.IwebelementsEx
{
    public class RegistartionForm
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            //calling browser driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"file:///D:/Manual%20Testing%20Notes-20221205T232832Z-001/Manual%20Testing%20Notes/webiste/registration/index.html");
        }

       // [Test]
        public void Test1()
        {

          IWebElement EmailTbox =  driver.FindElement(By.XPath("/html/body/form/fieldset[1]/p[1]/input[1]"));
          Console.WriteLine("EmailTbox is Enabled ? " + EmailTbox.Enabled);

          IWebElement RepeatEmailTbox = driver.FindElement(By.XPath("/html/body/form/fieldset[1]/p[1]/input[2]"));
          Console.WriteLine("RepeatEmailTbox is Enabled ? " + RepeatEmailTbox.Enabled);

            try
            {
                IWebElement PasswordTbox = driver.FindElement(By.XPath("/html/body/form/fieldsetwqwq[1]/p[2]/input[1]"));
                Console.WriteLine("EmailTbox is Displayed ? " + PasswordTbox.Displayed);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception Occured : ");
            }
         IWebElement RepeatPasswordTbox = driver.FindElement(By.XPath("/html/body/form/fieldset[1]/p[2]/input[2]"));
         Console.WriteLine("RepeatEmailTbox is Displayed ? " + RepeatPasswordTbox.Displayed);


            IWebElement verfiyText = driver.FindElement(By.XPath("/html/body/form/fieldset[1]/legend"));
            Console.WriteLine(" color: " + verfiyText.GetCssValue("color"));
            Console.WriteLine(" font-size: " + verfiyText.GetCssValue("font-size"));
            Console.WriteLine(" font-weight: " + verfiyText.GetCssValue("font-weight"));
            Console.WriteLine(" font-family: " + verfiyText.GetCssValue("font-family"));







        }

        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }
}
