using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using static MarsFramework.Global.GlobalDefinitions;
using NUnit.Framework;
using AutoItX3Lib;


namespace MarsFramework.Pages
{
    public class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit Availability button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option Part Time
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Part Time')]")]
        private IWebElement AvailabilityOptPartTime { get; set; }

        //Click on Availability Time option Full Time
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Full Time')]")]
        private IWebElement AvailabilityOptFullTime { get; set; }

        //Get Availability Time Value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")]
        private IWebElement AvailabilityTimeValue { get; set; }

        
        //Click on Edit Hours button        
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement HoursEdit { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on Hours option 
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Less than 30hours a week')]")]
        private IWebElement HoursOptionLessThan30PerWeek { get; set; }

        //Click on Hours option 
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'More than 30hours a week')]")]
        private IWebElement HoursOptionMoreThan30PerWeek { get; set; }

        //Click on Hours option 
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'As needed')]")]
        private IWebElement HoursOptionAsNeeded { get; set; }

        //Get Hours Value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span")]
        private IWebElement HourseValue { get; set; }


        //Click on EditEarn Target
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement EarnTargetEdit { get; set; }

        //Click on Earn Target dropdown
        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement EarnTargetDropdown { get; set; }

        //Click on Earn Target option         
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Less than $500 per month')]")]
        private IWebElement EarnTargetLessThan500PerMonth { get; set; }

        //Click on Earn Target option 
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Between $500 and $1000 per month')]")]
        private IWebElement EarnTargetBetween500and1000PerMonth { get; set; }

        //Click on Earn Target option 
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'More than $1000 per month')]")]
        private IWebElement EarnTargetMoreThan1000PerMonth { get; set; }

        //Get Hours Value
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span")]
        private IWebElement EarnTargetValue { get; set; }


        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion

        public void SelectAvailability(string option)
        {
            try
            {
                AvailabilityTimeEdit.Click();                
                AvailabilityTime.Click();
                Thread.Sleep(2000);                

                if (option == "Part Time")
                {
                    AvailabilityOptPartTime.Click();
                }
                if (option == "Full Time")
                {
                    AvailabilityOptFullTime.Click();
                }

                WaitForElement(driver, By.XPath("//div[contains(text(),'Availability updated')]"));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);            
            }
        }

        public void SelectHours(string option)
        {
            try
            {
                HoursEdit.Click();
                AvailabilityHours.Click();
                Thread.Sleep(2000);

                if (option == "Less than 30hours a week")
                {
                    HoursOptionLessThan30PerWeek.Click();
                }
                else if (option == "More than 30hours a week")
                {
                    HoursOptionMoreThan30PerWeek.Click();
                }
                else if (option == "As needed")
                {
                    HoursOptionAsNeeded.Click();
                }

                WaitForElement(driver, By.XPath("//div[contains(text(),'Availability updated')]"));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        public void SelectEarnTarget(string option)
        {
            try
            {
                EarnTargetEdit.Click();
                EarnTargetDropdown.Click();
                Thread.Sleep(2000);

                if (option == "Less than $500 per month")
                {
                    EarnTargetLessThan500PerMonth.Click();
                }
                else if (option == "Between $500 and $1000 per month")
                {
                    EarnTargetBetween500and1000PerMonth.Click();
                }
                else if (option == "More than $1000 per month")
                {
                    EarnTargetMoreThan1000PerMonth.Click();
                }

                WaitForElement(driver, By.XPath("//div[contains(text(),'Availability updated')]"));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        public string GetAvailabilityTimeValue()
        {
            return AvailabilityTimeValue.Text;
        }

        public string GetHoursValue()
        {
            return HourseValue.Text;
        }

        public string GetEarnTargetValue()
        {
            return EarnTargetValue.Text;
        }
    }
}