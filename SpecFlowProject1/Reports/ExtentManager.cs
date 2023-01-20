using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SpecFlowProject1.Reports
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string reportpath = @"C:\Users\giris\source\repos\SeleniumCSharp-Learning\SpecFlowProject1\Reports\index.html";

                htmlReporter = new ExtentHtmlReporter(reportpath);
                extent = new ExtentReports();

                extent.AttachReporter(htmlReporter);

                extent.AddSystemInfo("OS", "WINDOWS");
                extent.AddSystemInfo("HOST NAME", "GIRISH");
                extent.AddSystemInfo("ENV", "ALPHA");
                extent.AddSystemInfo("USERNAME", "GIRISH_RATHODE");

                string extentconfigpath = @"C:\Users\giris\source\repos\SeleniumCSharp-Learning\SpecFlowProject1\Reports\MyOwnReport.html";
                htmlReporter.LoadConfig(extentconfigpath);
            }
            return extent;
        }
    }
}
