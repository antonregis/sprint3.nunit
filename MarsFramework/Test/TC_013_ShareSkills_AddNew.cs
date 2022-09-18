using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_013_ShareSkills_AddNew : Base
    {        
        [Test]
        public void TC_013_01_CheckIfTheUserIsAbleToAddShareskillWithValidInputs()
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

        [Test]
        public void TC_013_02_CheckIfTheUserIsAbleToAddShareskillWithMaliciousTitle()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                ShareSkill ShareSkillObj = new ShareSkill();

                //Action
                ShareSkillObj.EnterShareSkillInvalidDescription(2);

                // Assertion
                string resultStatusNotification = ShareSkillObj.GetNotificationInvalidEntry();
                string expectedStatusNotification = "Please complete the form correctly.";
                Assert.That(resultStatusNotification, Is.EqualTo(expectedStatusNotification));
                Console.WriteLine(resultStatusNotification);

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
        public void TC_013_03_CheckIfTheUserIsAbleToAddShareskillWithInvalidFileSizeAndType()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                ShareSkill ShareSkillObj = new ShareSkill();

                //Action
                ShareSkillObj.EnterShareSkillInvalidWorkSampleFile(3);

                // Assertion
                string resultStatusNotification = ShareSkillObj.GetInvalidFileTypeNotification();
                string expectedStatusNotification = "Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x)";
                Assert.That(resultStatusNotification, Is.EqualTo(expectedStatusNotification));
                Console.WriteLine(resultStatusNotification);

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