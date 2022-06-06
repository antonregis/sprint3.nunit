using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_015_ManageListings_Delete : Base
    {        
        [Test]
        public void TC_015_CheckIfTheUserIsAbleToDeleteListing()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                ManageListings ManageListingsObj = new ManageListings();

                // Action                
                ManageListingsObj.DeleteShareSkill();

                // Assertion              
                string resultStatusNotification = ManageListingsObj.GetNotification();
                string expectedStatusNotification = "has been deleted";
                Assert.That(resultStatusNotification.Contains(expectedStatusNotification));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
    }
}