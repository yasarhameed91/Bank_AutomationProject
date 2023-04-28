using Bank_AutomationProject.Configurations;
using Bank_AutomationProject.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;
        public static IConfig config = new AppConfigReader();

        public static void Initialization()
        {
            driver = new ChromeDriver();         
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Url = config.GetUrl();        
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
        }

        public string GetUrl()
        {
           string CurrentURL= driver.Url;
            return CurrentURL;
        }
        public string GetPageTitle()
        {
            string CurrentPageTitle = driver.Title;
            return CurrentPageTitle;
        }

        public void WaitUntilHomePageLoads()        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleIs("Guru99 Bank Manager HomePage"));

        }
        public void CloseBrowserWindow()
        {
            driver.Quit();
        }




    }
}
