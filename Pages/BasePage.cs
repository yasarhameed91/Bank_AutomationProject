using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        public static void Initialization()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.demo.guru99.com/v4/");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);


        }

       public string GetPageTitle()
        {
            String pageTitle=driver.Title;
            return pageTitle;
        }

        public void WaitUntilElementVisible(By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void WaitUntilElementClickable(By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public void Click(By by)
        {
            WaitUntilElementClickable(by);
            driver.FindElement(by).Click();
        }

        public void SendKeys(By by, string text)
        {
            WaitUntilElementVisible(by);
            driver.FindElement(by).SendKeys(text);
        }

        public void CloseBrowserWindow()
        {
            driver.Quit();
        }




    }
}
