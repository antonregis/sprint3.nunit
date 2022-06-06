using NUnit.Framework;
using MarsFramework.Global;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_001_Registration : Base
    {
        [OneTimeSetUp]
        public void StartExtentReports()
        {
            // Initialize ExtentReports
            var htmlReporter = new ExtentHtmlReporter(ReportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [Test]
        [Ignore ("Skipping test, waiting for code")]
        public void TC_001_ValidateRegistration()
        { 
            // Do nothing
            // Place holder method
            // Waiting for code 
        }
    }
}