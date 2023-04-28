using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "uid")]
        private IWebElement UserName { get; set; }
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.Name, Using = "btnLogin")]
        private IWebElement LoginButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "tr[align='center'] td")]
        private IWebElement GetTheManagerId { get; set; }

        public LoginPage()
        {
        PageFactory.InitElements(driver, this);
        }

        public HomePage Login(string un, string pwd)
        {
            UserName.SendKeys(un); 
            Password.SendKeys(pwd); 
            LoginButton.Click();
            return new HomePage();
        }
        public string GetTheLoginId()
        {
            string ActualText=GetTheManagerId.Text;
            return ActualText;
        }


    }

    
}
