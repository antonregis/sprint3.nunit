using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;


namespace MarsFramework.Pages
{
    public class SearchSkills
    {
        public SearchSkills()
        {
            PageFactory.InitElements(driver, this);
        }


        #region Initialize Web Elements (Page Factory style)

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //Search Input 1
        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[1]")]
        private IWebElement searchTextbox { get; set; }

        //Click on Search1
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/div/div/i")]
        private IWebElement search { get; set; }

        //Search Input 2
        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[2]")]
        private IWebElement searchTextbox2 { get; set; }

        //Click on Search2
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div[2]/i")]
        private IWebElement search2 { get; set; }

        //Click on Online
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Online')]")]
        private IWebElement online { get; set; }


        //Click on Onsite
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Onsite')]")]
        private IWebElement onsite { get; set; }

        //Click on ShowAll
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'ShowAll')]")]
        private IWebElement showAll { get; set; }
      

        //Category filters
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Graphics & Design')]")] private IWebElement categoryGraphicsDesign { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Digital Marketing')]")] private IWebElement categoryDigitalMarketing { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Writing & Translation')]")] private IWebElement categoryWritingTranslation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Video & Animation')]")] private IWebElement categoryVideoAnimation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Music & Audio')]")] private IWebElement categoryMusicAudio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Programming & Tech')]")] private IWebElement categoryProgrammingTech { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Business')]")] private IWebElement categoryBusiness { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item category' and contains(text(),'Fun & Lifestyle')]")] private IWebElement categoryFunLifestyle { get; set; }

        //Subcategory filters
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Book & Album covers')]")] private IWebElement subCategoryBookAlbumCovers { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Social Media Marketing')]")] private IWebElement subCategorySocialMediaMarketing { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Proof Reading & Editing')]")] private IWebElement subCategoryProofReadingEditing { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Lyric & Music Videos')]")] private IWebElement subCategoryLyricMusicVideos { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Voice Over')]")] private IWebElement subCategoryVoiceOver { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'QA')]")] private IWebElement subCategoryQA { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Business Tips')]")] private IWebElement subCategoryBusinessTips { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='item subcategory' and contains(text(),'Health, Nutrition & Fitness')]")] private IWebElement subCategoryHealthNutritionFitness { get; set; }

        //Subcategory results
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div[1]/div[1]/div/a[4]/span")] private IWebElement resultBookAlbumCovers { get; set; }      
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[4]/span")] private IWebElement resultSocialMediaMarketing { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[6]/span")] private IWebElement resultProofReadingEditing { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[8]/span")] private IWebElement resultLyricMusicVideos { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[8]/span")] private IWebElement resultVoiceOver { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[11]/span")] private IWebElement resultQA { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[9]/span")] private IWebElement resultBusinessTips { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a[13]/span")] private IWebElement resultHealthNutritionFitness { get; set; }

        //Storing All Categories
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a/b")]
        private IWebElement allCategories { get; set; }

        //Storing All Categories result
        [FindsBy(How = How.XPath, Using = "//div[@id='service-search-section']/div[2]/div/section/div/div/div/div/a/span")]
        private IWebElement allCategoriesResult { get; set; }

        #endregion


        public void SearchAllCategories() 
        {
            try
            {               
                WaitForPageToLoad();
                search.Click();
                WaitForPageToLoad();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }    
        }

        public void SearchBySubCategory(string skillToSearch, string category, string subCategory)
        {
            try
            {
                driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url") + "/Home/Search");
                WaitForPageToLoad();                

                if (category == "Graphics & Design")
                {
                    categoryGraphicsDesign.Click();
                    subCategoryBookAlbumCovers.Click();
                }
                else if (category == "Digital Marketing")
                {
                    categoryDigitalMarketing.Click();
                    subCategorySocialMediaMarketing.Click(); 
                }
                else if (category == "Writing & Translation")
                {
                    categoryWritingTranslation.Click();
                    subCategoryProofReadingEditing.Click();
                }
                else if (category == "Video & Animation")
                {
                    categoryVideoAnimation.Click();
                    subCategoryLyricMusicVideos.Click();
                }
                else if (category == "Music & Audio")
                {
                    categoryMusicAudio.Click();
                    subCategoryVoiceOver.Click();
                }
                else if (category == "Programming & Tech")
                {
                    categoryProgrammingTech.Click();
                    subCategoryQA.Click();
                }
                else if (category == "Business")
                {
                    categoryBusiness.Click();   
                    subCategoryBusinessTips.Click();
                }
                else if (category == "Fun & Lifestyle")
                {
                    categoryFunLifestyle.Click();
                    subCategoryHealthNutritionFitness.Click();
                }
                else 
                {
                    Console.WriteLine("invalid category");
                }

                WaitForPageToLoad();
                searchTextbox2.Clear();
                searchTextbox2.SendKeys(skillToSearch);
                search2.Click();
                WaitForPageToLoad();                
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        public void SearchByFilter(string filter)
        {
            try
            {
                WaitForPageToLoad();
                search.Click();
                WaitForPageToLoad();

                if (filter == "Online")
                {
                    online.Click();
                }
                else if (filter == "Onsite")
                {
                    onsite.Click();
                }
                else if (filter == "ShowAll")
                {
                    showAll.Click();
                }
                else 
                {
                    Console.WriteLine("Invalid filter");
                }

                WaitForPageToLoad();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public string GetResultSubCategory(string subCategory)
        {
            string result = null;

            if (subCategory == "Book & Album covers")
            {
                result = resultBookAlbumCovers.Text;    
            }
            else if (subCategory == "Social Media Marketing")
            {
                result = resultSocialMediaMarketing.Text;
            }
            else if (subCategory == "Proof Reading & Editing")
            {
                result = resultProofReadingEditing.Text;
            }
            else if (subCategory == "Lyric & Music Videos")
            {
                result = resultLyricMusicVideos.Text;
            }
            else if (subCategory == "Voice Over")
            {
                result = resultVoiceOver.Text;
            }
            else if (subCategory == "QA")
            {
                result = resultQA.Text;
            }
            else if (subCategory == "Business Tips")
            {
                result = resultBusinessTips.Text;
            }
            else if (subCategory == "Health, Nutrition & Fitness")
            {
                result = resultHealthNutritionFitness.Text;
            }
            else 
            {
                result = "invalid subCategory";
            }

            return result;
        }

        public string GetAllCategories()
        {
            return allCategories.Text;
        }

        public string GetAllCategoriesResult()
        {
            return allCategoriesResult.Text;
        }

        public string GetPlaceholder1()
        {
            return "placeholder";
        }

        public string GetPlaceholder2()
        {
            return "placeholder";
        }
    }
}