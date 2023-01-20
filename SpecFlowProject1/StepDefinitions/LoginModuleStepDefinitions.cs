using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Browser_Config;
using SpecFlowProject1.Reports;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginModuleStepDefinitions
    {
        string BrowserType = "chrome";
        string testUrl = "https://katalon-demo-cura.herokuapp.com/";
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;



        [Given(@"Navigate to login page")]
        public void GivenNavigateToLoginPage()
        {           
            BrowserLauncher.openBrowser(BrowserType, testUrl);
            test = rep.CreateTest("User_Login");
            test.Log(Status.Pass, "GivenNavigateToLoginPage");
            rep.Flush();
        }

        [When(@"verify user is on logInPage")]
        public void WhenVerifyUserIsOnLogInPage()
        {
            string ActualpageUrl = BrowserLauncher.driver.Url;
            Assert.That(ActualpageUrl, Is.EqualTo(testUrl));

            test = rep.CreateTest("User_Login");
            test.Log(Status.Pass, "WhenVerifyUserIsOnLogInPage");
            rep.Flush();

        }

        [Then(@"Enter the username and password")]
        public void ThenEnterTheUsernameAndPassword()
        {
            BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"btn-make-appointment\"]")).Click();
            BrowserLauncher.driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            BrowserLauncher.driver.FindElement(By.Name("password")).SendKeys("ThisIsNotAPassword");
            test = rep.CreateTest("User_Login");
            test.Log(Status.Pass, "ThenEnterTheUsernameAndPassword");
            rep.Flush();

        }

        [Then(@"Click on LogIn button")]
        public void ThenClickOnLogInButton()
        {
            BrowserLauncher.driver.FindElement(By.XPath("//*[@id=\"btn-login\"]")).Click();
            test = rep.CreateTest("User_Login");
            test.Log(Status.Pass, "ThenClickOnLogInButton");
            rep.Flush();
        }
    }
}
