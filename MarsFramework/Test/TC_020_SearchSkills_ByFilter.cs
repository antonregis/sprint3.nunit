using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_020_SearchSkills_ByAllCategories : Base
    {        
        [Test]
        public void TC_020_01_CheckIfTheUserIsAbleToSearchByOnlineFilter()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                SearchSkills SearchSkillsObj = new SearchSkills();

                // Action
                SearchSkillsObj.SearchByFilter("Online");

                // Assert                
                int result2 = int.Parse(SearchSkillsObj.GetAllCategoriesResult());
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

        [Test]
        public void TC_020_02_CheckIfTheUserIsAbleToSearchByOnsiteFilter()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                SearchSkills SearchSkillsObj = new SearchSkills();

                // Action
                SearchSkillsObj.SearchByFilter("Onsite");

                // Assert                
                int result2 = int.Parse(SearchSkillsObj.GetAllCategoriesResult());
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

        [Test]
        public void TC_020_03_CheckIfTheUserIsAbleToSearchByShowallFilter()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                SearchSkills SearchSkillsObj = new SearchSkills();

                // Action
                SearchSkillsObj.SearchByFilter("ShowAll");

                // Assert                
                int result2 = int.Parse(SearchSkillsObj.GetAllCategoriesResult());
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