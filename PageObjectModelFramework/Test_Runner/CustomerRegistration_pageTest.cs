using PageObjectModelFramework.Browser_Config;
using PageObjectModelFramework.Customer_REG_LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.Test_Runner
{
    public class CustomerRegistration_pageTest
    {

        public static string testUrl = "https://parabank.parasoft.com/";
        public static string Browsertype = "chrome";

        [Test]
        public static void cus_reg_tc01()
        {
            BrowserLauncher.openBrowser(Browsertype,testUrl);

            CustomerRegistration cus_reg = new CustomerRegistration(BrowserLauncher.driver);
            cus_reg.clickRegisterLnk();
            cus_reg.firstNameTbox("Prem");
            cus_reg.lastNameTbox("Kumar");
            cus_reg.addressTbox("#11 book strret , Hill town");
            cus_reg.cityTbox("Guntur");
            cus_reg.stateTbox("AP");
            cus_reg.zipCodeTbox("321234");
            cus_reg.phoneNumberTbox("9876543210");
            cus_reg.ssnTbox("123456789");
            cus_reg.usernameTbox("premKumar0777");
            cus_reg.passwordTbox("premKumar@0777");
            cus_reg.repeatedPasswordTbox("premKumar@0777");
            cus_reg.submitBtn();

        }

    }
}
