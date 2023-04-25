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
        IWebElement UserName;
        [FindsBy(How = How.Name, Using = "password")]
        IWebElement Password;
        [FindsBy(How = How.Name, Using = "btnLogin")]
        IWebElement LoginButton;
        [FindsBy(How = How.XPath, Using = "tr[align='center'] td")]
        IWebElement GetTheManagerId;

        public LoginPage()
        {
        PageFactory.InitElements(driver, this);
        }

        public void Login(string Username,string Pwd)
        {
            UserName.SendKeys(Username);
            Password.SendKeys(Pwd);
            LoginButton.Click();
        }
        public string GetTheLoginId()
        {
            string ActualText=GetTheManagerId.Text;
            return ActualText;
        }


    }

    
}
