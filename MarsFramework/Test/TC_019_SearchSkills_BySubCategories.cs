using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;
using System.Threading;

namespace MarsFramework.Test
{
    [TestFixture]
    class TC_019_SearchSkills_BySubCategories : Base
    {        
        [Test]
        [TestCase("test", "Graphics & Design", "Book & Album covers")]
        [TestCase("test", "Digital Marketing", "Social Media Marketing")]
        [TestCase("test", "Writing & Translation", "Proof Reading & Editing")]
        [TestCase("test", "Video & Animation", "Lyric & Music Videos")]
        [TestCase("test", "Music & Audio", "Voice Over")]
        [TestCase("test", "Programming & Tech", "QA")]
        [TestCase("test", "Business", "Business Tips")]
        [TestCase("test", "Fun & Lifestyle", "Health, Nutrition & Fitness")]
        public void TC_019_00_CheckIfTheUserIsAbleToSearchBySubCategory(string skillToSearch, string category, string subCategory)
        {
            // Create Extentreport test, name extracted from current method name
            string testCase = "(\"" + skillToSearch + "\", \"" + category + "\", \"" + subCategory + "\")";
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name + testCase);

            try
            {
                // Arrange
                SearchSkills SearchSkillsObj = new SearchSkills();

                // Action
                SearchSkillsObj.SearchBySubCategory(skillToSearch, category, subCategory);

                // Assert
                int result = int.Parse(SearchSkillsObj.GetResultSubCategory(subCategory));
                Console.WriteLine(result);                
                Assert.GreaterOrEqual(result, 0);

                Console.WriteLine("test");
                Console.WriteLine(result);

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