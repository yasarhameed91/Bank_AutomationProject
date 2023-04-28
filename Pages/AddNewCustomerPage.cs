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
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement CustomerName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@value='m']")]
        private IWebElement SelectGender { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='dob']")]
        private IWebElement DOB { get; set; }
        [FindsBy(How = How.XPath, Using = "//textarea[@name='addr']")]
        private IWebElement Address { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='city']")]
        private IWebElement City { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='state']")]
        private IWebElement State { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='pinno']")]
        private IWebElement Pincode { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='telephoneno']")]
        private IWebElement MobileNumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='emailid']")]
        private IWebElement EmailId { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='sub']")]
        private IWebElement SubmitBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='res']")]
        private IWebElement ResetBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@id='customer']/tbody/tr[1]/td")]
        private IWebElement RegisteredSuccessMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@id='customer']/tbody/tr")]
        private IList<IWebElement> RegisteredCustomerDetails { get; set; }
        [FindsBy(How = How.LinkText, Using = "New Customer")]
        private IWebElement NewCustomerLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Continue")]
        private IWebElement ContinueLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//tbody/tr[4]/td[2]")]
        private IWebElement CustomerId { get; set; }


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
            Random RndNum = new Random();
            CustomerName.SendKeys("test customer");
            SelectGender.Click();
            DOB.SendKeys("03/09/1991");
            Address.SendKeys("64 Ranstone Gardens");
            City.SendKeys("Toronto");
            State.SendKeys("Ontario");
            Pincode.SendKeys("123456");
            MobileNumber.SendKeys("6475261718");
            EmailId.SendKeys("testcustomer"+ RndNum.Next()+"@gmail.com");
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
