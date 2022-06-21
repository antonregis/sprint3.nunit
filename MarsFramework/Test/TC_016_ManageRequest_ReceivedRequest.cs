using NUnit.Framework;
using MarsFramework.Global;
using MarsFramework.Pages;
using AventStack.ExtentReports;
using System;


namespace MarsFramework.Test
{
    [TestFixture]
    class TC_016_ManageRequest_ReceivedRequest : Base
    {        
        [Test]
        public void TC_016_01_CheckIfTheUserIsAbleToAcceptRequest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                ReceivedRequest ReceivedRequestObj = new ReceivedRequest();

                // Action                
                ReceivedRequestObj.AcceptRequest();

                // Assertion              
                string resultStatusNotification = ReceivedRequestObj.GetNotification();
                string expectedStatusNotification = "has been updated";
                Console.WriteLine(resultStatusNotification);
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

        [Test]
        public void TC_016_02_CheckIfTheUserIsAbleToDeclineRequest()
        {
            // Create Extentreport test, name extracted from current method name
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                // Arrange
                ReceivedRequest ReceivedRequestObj = new ReceivedRequest();

                // Action                
                ReceivedRequestObj.DeclineRequest();

                // Assertion              
                string resultStatusNotification = ReceivedRequestObj.GetNotification();
                string expectedStatusNotification = "has been updated";
                Console.WriteLine(resultStatusNotification);
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