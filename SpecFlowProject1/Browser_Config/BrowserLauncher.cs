using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Browser_Config
{
    public class BrowserLauncher
    {
        public static IWebDriver driver;

        public static void openBrowser(string BrowserType , string TestURL)
        {
            if (BrowserType.Equals("chrome"))
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(TestURL);
                driver.Manage().Window.Maximize();
            }

            else if (BrowserType.Equals("edge"))
            {
                driver = new EdgeDriver();
                driver.Navigate().GoToUrl(TestURL);
                driver.Manage().Window.Maximize();
            }

            else if (BrowserType.Equals("firefox"))
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(TestURL);
                driver.Manage().Window.Maximize();
            }

            else
            {
                Console.WriteLine("Invalid Browser Type");
            }
        }

        public static void closeBrowser() 
        {        
            driver.Quit();
        }

    }
}
