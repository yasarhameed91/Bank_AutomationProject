using Bank_AutomationProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Test
{
   public class AddNewCustomerPageTest:BasePage
    {
        LoginPage Lp;
        HomePage Hp;
        AddNewCustomerPage ANCp;
        [SetUp]
        public void Setup()
        {
            Initialization();
            Lp = new LoginPage();
            Hp = Lp.Login(ConfigurationManager.AppSettings.Get("UserId"), ConfigurationManager.AppSettings.Get("Password"));
            ANCp = new AddNewCustomerPage();
        }

        [Test]
        public void VerfiyAddNewCustomerPageTest()
        {
            ANCp.ClickOnNewCustomer();
            string ActualAddNewCustomerPageTitle = ANCp.VerifyTheAddNewCustomerPageTitle();
            string ActualAddNewCustomerPageUrl = ANCp.VerifyAddNewCustomerPageURL();
            Assert.AreEqual("Guru99 Bank New Customer Entry Page", ActualAddNewCustomerPageTitle);
            Assert.AreEqual("https://www.demo.guru99.com/v4/manager/addcustomerpage.php", ActualAddNewCustomerPageUrl);
        }
        [Test]
        public void AddNewCustomerTest()
        {
            ANCp.ClickOnNewCustomer();
            ANCp.EnterNewCustomerDetails();
            ANCp.ClickSubmitButton();
            string SuccessMsg=ANCp.VerifyTheCustomerRegisteredSuccessfully();
            Assert.AreEqual("Customer Registered Successfully!!!", SuccessMsg);
            ANCp.GetRegisteredCustomerData();
            ANCp.ClickOnContinueButton();
            WaitUntilHomePageLoads();
            string ActualHomePageTitle = Hp.GetTheHomePageTitle();
            Assert.AreEqual("Guru99 Bank Manager HomePage", ActualHomePageTitle);
            string ActualHomePageWelcomeText = Hp.GetTheHomePageWelcomeText();
            Assert.AreEqual("Welcome To Manager's Page of Guru99 Bank", ActualHomePageWelcomeText);
            Assert.IsTrue(Hp.VerifyTheWelcomePageImageIsDisplayed());
        }
        [Test]
            public void ValidateUserBackToHomePageByClickingHomeButton()
        {
            ANCp.ClickOnNewCustomer();
            ANCp.ClickOnHomeButton();
            string ActualHomePageTitle = Hp.GetTheHomePageTitle();
            Assert.AreEqual("Guru99 Bank Manager HomePage", ActualHomePageTitle);
            string ActualHomePageWelcomeText = Hp.GetTheHomePageWelcomeText();
            Assert.AreEqual("Welcome To Manager's Page of Guru99 Bank", ActualHomePageWelcomeText);
            Assert.IsTrue(Hp.VerifyTheWelcomePageImageIsDisplayed());
        }
        [TearDown]
        public void TearDown()
        {
            CloseBrowserWindow();
        }
    }
}
