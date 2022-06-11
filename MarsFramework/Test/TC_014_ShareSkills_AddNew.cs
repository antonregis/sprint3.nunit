using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_014_ShareSkills_AddNew : Base
    {        
        [Test]
        public void TC_014_ValidateAddNewShareSkill()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                ShareSkill ShareSkillObj = new ShareSkill();
                
                //Action
                ShareSkillObj.EnterShareSkill(1);

                // Assertion
                string resultStatusNotification = ShareSkillObj.GetNotification();
                string expectedStatusNotification = "Service Listing Added successfully";
                Assert.That(resultStatusNotification, Is.EqualTo(expectedStatusNotification));

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