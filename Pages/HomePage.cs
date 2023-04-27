using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Pages
{
    public class HomePage:BasePage
    {
        [FindsBy(How = How.XPath, Using = "//marquee[@behavior='alternate']")]
        private readonly IWebElement GetTheWelcomeManagerPageText;
        [FindsBy(How = How.XPath, Using = "//tbody//tr//center//img[1]")]
        private readonly IWebElement GetTheWelcomeManagerPageImg;

        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }

        public string GetTheHomePageTitle()
        {
            string ActualHomePageTitle=driver.Title;
            return ActualHomePageTitle;
        }
        public string GetTheHomePageWelcomeText()
        {
            string ActualWelcomeManagerPageText = GetTheWelcomeManagerPageText.Text;
            return ActualWelcomeManagerPageText;
        }

        public Boolean VerifyTheWelcomePageImageIsDisplayed()
        {
            return GetTheWelcomeManagerPageImg.Displayed;

        }




    }
}
