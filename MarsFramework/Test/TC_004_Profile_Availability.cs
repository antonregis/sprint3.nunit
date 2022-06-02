using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_004_Profile_Availability : Base
    {        
        [Test]
        public void TC_004_01_CheckIfTheUserIsAbleToSelectTheAvailability()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);            

            try
            {
                // Arrange
                Profile ProfileObj = new Profile();

                // Action
                ProfileObj.SelectAvailability("Part Time");

                // Assertion
                string result = ProfileObj.GetAvailabilityTimeValue();
                string expectedResult = "Part Time";
                Assert.That(result, Is.EqualTo(expectedResult));
                
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

        [Test]
        public void TC_004_02_CheckIfTheUserIsAbleToEditTheAvailability()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                Profile ProfileObj = new Profile();

                // Action
                ProfileObj.SelectAvailability("Full Time");

                // Assertion
                string result = ProfileObj.GetAvailabilityTimeValue();
                string expectedResult = "Full Time";
                Assert.That(result, Is.EqualTo(expectedResult));

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