using NUnit.Framework;
using MarsFramework.Global;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_029_JobScheduler : Base
    {
        [Test]
        [Ignore("Skipping test, waiting for code.")]
        public void TC_029_ValidateJobScheduler()
        { 
            // Do nothing
            // Place holder method
            // Waiting for code 
        }

        [OneTimeTearDown]
        public void SaveExtentReports()
        {
            // Save Extentereport html file
            extent.Flush();
        }
    }
}