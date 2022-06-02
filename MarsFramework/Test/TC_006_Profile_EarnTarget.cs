using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_006_Profile_EarnTarget : Base
    {        
        [Test]
        public void TC_006_01_CheckIfTheUserIsAbleToSelectTheEarnTarget()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                Profile ProfileObj = new Profile();

                // Action
                ProfileObj.SelectEarnTarget("Less than $500 per month");

                // Assertion
                string result = ProfileObj.GetEarnTargetValue();
                string expectedResult = "Less than $500 per month";
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
        [TestCase("Between $500 and $1000 per month")]
        [TestCase("More than $1000 per month")]
        public void TC_006_02_CheckIfTheUserIsAbleToEditTheEarnTarget(string dropdownOption)
        {
            // Create Extentreport test, name extracted from current method name
            string testCase = "(\"" + dropdownOption + "\")";
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name + testCase);

            try
            {
                // Arrange
                Profile ProfileObj = new Profile();

                // Action
                ProfileObj.SelectEarnTarget(dropdownOption);

                // Assertion
                string result = ProfileObj.GetEarnTargetValue();
                string expectedResult = dropdownOption;
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