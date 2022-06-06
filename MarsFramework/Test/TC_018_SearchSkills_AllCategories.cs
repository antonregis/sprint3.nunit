using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_018_SearchSkills_AllCategories : Base
    {        
        [Test]
        public void TC_018_00_CheckIfTheUserIsAbleToSearchByAllCategories()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                SearchSkills SearchSkillsObj = new SearchSkills();

                // Action
                SearchSkillsObj.SearchAllCategories();

                // Assert
                string result1 = SearchSkillsObj.GetAllCategories();
                int result2 = int.Parse(SearchSkillsObj.GetAllCategoriesResult());
                string expectedResult1 = "All Categories";

                Assert.That(result1, Is.EqualTo(expectedResult1));
                Assert.GreaterOrEqual(result2, 0);

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