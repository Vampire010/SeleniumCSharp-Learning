using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.Customer_REG_LogIn
{
    public class Customer_LogIn
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement username { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginPanel\"]/form/div[3]/input")]
        private IWebElement submitbtn { get; set; }

        public Customer_LogIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       

        public void usernameTbox(string value)
        {
            username.SendKeys(value);
        }
        public void passwordTbox(string value)
        {   
            password.SendKeys(value);
        }

        public void SubmitButton()
        {
            submitbtn.Click();
        }
    }
}
