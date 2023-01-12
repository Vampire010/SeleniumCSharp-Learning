using PageObjectModelFramework.Browser_Config;
using PageObjectModelFramework.Customer_REG_LogIn;
using PageObjectModelFramework.TestDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.Test_Runner
{
    public class CustomerLogINPageTest
    {

        public static string testUrl = "https://parabank.parasoft.com/";
        public static string Browsertype = "chrome";
        public string username;
        public string password;


        [Test]
        public  void cus_login_tc01()
        {
            BrowserLauncher.openBrowser(Browsertype, testUrl);

            Customer_LogIn cus_login = new Customer_LogIn(BrowserLauncher.driver);

            ExcelOperations.PopulateInColletion(@"C:\Users\giris\source\repos\SeleniumCSharp-Learning\PageObjectModelFramework\TestDataAccess\TestData.xlsx");
            for (int i = 1; i < 2; i++)
            {
                this.username = ExcelOperations.ReadData(i, "Username");
                Console.WriteLine(username);
                this.password = ExcelOperations.ReadData(i, "Password");
                Console.WriteLine(password);
            }
            cus_login.usernameTbox(username);
            cus_login.passwordTbox(password);
            cus_login.SubmitButton();

        }
    }
}
