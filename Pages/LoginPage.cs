using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "uid")]
        private readonly IWebElement UserName;
        [FindsBy(How = How.Name, Using = "password")]
        private readonly IWebElement Password;
        [FindsBy(How = How.Name, Using = "btnLogin")]
        private readonly IWebElement LoginButton;
        [FindsBy(How = How.CssSelector, Using = "tr[align='center'] td")]
        private readonly IWebElement GetTheManagerId;

        public LoginPage()
        {
        PageFactory.InitElements(driver, this);
        }

        public HomePage Login(string Username,string Pwd)
        {
            UserName.SendKeys(Username);
            Password.SendKeys(Pwd);
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
