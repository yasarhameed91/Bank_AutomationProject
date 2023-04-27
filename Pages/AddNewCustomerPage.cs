using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Pages
{
    public class AddNewCustomerPage:BasePage
    {
        [FindsBy(How = How.Name, Using = "name")]
        private readonly IWebElement CustomerName;
        [FindsBy(How = How.XPath, Using = "//input[@value='m']")]
        private readonly IWebElement SelectGender;
        [FindsBy(How = How.Name, Using = "dob")]
        private readonly IWebElement DOB;
        [FindsBy(How = How.Name, Using = "addr")]
        private readonly IWebElement Address;
        [FindsBy(How = How.Name, Using = "city")]
        private readonly IWebElement City;
        [FindsBy(How = How.Name, Using = "state")]
        private readonly IWebElement State;
        [FindsBy(How = How.Name, Using = "pinno")]
        private readonly IWebElement Pincode;
        [FindsBy(How = How.Name, Using = "telephoneno")]
        private readonly IWebElement MobileNumber;
        [FindsBy(How = How.Name, Using = "emailid")]
        private readonly IWebElement EmailId;
        [FindsBy(How = How.Name, Using = "password")]
        private readonly IWebElement Password;
        [FindsBy(How = How.Name, Using = "sub")]
        private readonly IWebElement SubmitBtn;
        [FindsBy(How = How.Name, Using = "res")]
        private readonly IWebElement ResetBtn;
        [FindsBy(How = How.XPath, Using = "//table[@id='customer']/tbody/tr[1]/td")]
        private readonly IWebElement RegisteredSuccessMessage;
        [FindsBy(How = How.XPath, Using = "//table[@id='customer']/tbody/tr")]
        private IList<IWebElement> RegisteredCustomerDetails;
        [FindsBy(How = How.LinkText, Using = "New Customer")]
        private IWebElement NewCustomerLink;
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;
        [FindsBy(How = How.LinkText, Using = "Continue")]
        private IWebElement ContinueLink;
        [FindsBy(How = How.XPath, Using = "//tbody/tr[4]/td[2]")]
        private IWebElement CustomerId;


        public AddNewCustomerPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public string VerifyTheAddNewCustomerPageTitle()
        {
            string AddNewCustomerPageTitle=GetPageTitle();
            return AddNewCustomerPageTitle;
        }
        public string VerifyAddNewCustomerPageURL()
        {
            string AddNewCustomerPageURL = GetUrl();
            return AddNewCustomerPageURL;
        }

        public string VerifyAddNewCustomerSuccessPageURL()
        {
            string AddNewCustomerSuccessPageURL = GetUrl();
            return AddNewCustomerSuccessPageURL;
        }
        public void ClickOnNewCustomer()
        {
            NewCustomerLink.Click();
        }
        public void EnterNewCustomerDetails()
        {
            CustomerName.SendKeys("test customer");
            SelectGender.Click();
            DOB.SendKeys("03/09/1991");
            Address.SendKeys("64 Ranstone Gardens" + "\n" + "Scarborough" + "\n" + "Ontario, Canada");
            City.SendKeys("Toronto");
            State.SendKeys("Ontario");
            Pincode.SendKeys("123456");
            MobileNumber.SendKeys("6475261718");
            EmailId.SendKeys("testcustomer@gmail.com");
            Password.SendKeys("Abc123@");
        }

        public void ClickSubmitButton()
        {
            SubmitBtn.Click();
        }
        public void ClickResetButton()
        {
            ResetBtn.Click();
        }
        public string GetCustomerId()
        {
            string CusId = CustomerId.GetCssValue("td");          
            return CusId;
        }
        public string VerifyTheCustomerRegisteredSuccessfully()
        {
            string SuccessMsg=RegisteredSuccessMessage.Text;
            return SuccessMsg;
        }
        public void GetRegisteredCustomerData()
        {
            string ColumnFirst = "//table[@id='customer']/tbody/tr[";
            string ColumnLast = "]/td";
            IList<IWebElement> TableColumns;
            for(int i = 1; i < RegisteredCustomerDetails.Count; i++)
            {
                TableColumns = driver.FindElements(By.XPath(ColumnFirst+i+ColumnLast));
                foreach (var Tcol in TableColumns)
                {
                    Console.WriteLine(Tcol.Text);
                }
            }
        }

        public HomePage ClickOnContinueButton()
        {
            ContinueLink.Click();
            return new HomePage();
        }
        public HomePage ClickOnHomeButton()
        {
            HomeLink.Click();
            return new HomePage();
        }
        
    }
}
