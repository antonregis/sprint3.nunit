using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;
using System.IO;
using System.Globalization;

namespace MarsFramework
{
    [TestFixture]
    class Program : Base
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

        [Test]
        public void TC_005_01_CheckIfTheUserIsAbleToSelectTheHours()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                Profile ProfileObj = new Profile();

                // Action
                ProfileObj.SelectHours("Less than 30hours a week");

                // Assertion
                string result = ProfileObj.GetHoursValue();
                string expectedResult = "Less than 30hours a week";
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
        [TestCase("More than 30hours a week")]
        [TestCase("As needed")]
        public void TC_005_02_CheckIfTheUserIsAbleToEditTheHours(string dropdownOption)
        {
            // Create Extentreport test, name extracted from current method name            
            string testCase = "_" + dropdownOption.Replace(" ", String.Empty);
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name + testCase);

            try
            {
                // Arrange
                Profile ProfileObj = new Profile();

                // Action
                ProfileObj.SelectHours(dropdownOption);

                // Assertion
                string result = ProfileObj.GetHoursValue();
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
        
        
        [OneTimeTearDown]
        public void SaveExtentReports()
        {
            // Save Extentereport html file
            extent.Flush();
        }
    }
}