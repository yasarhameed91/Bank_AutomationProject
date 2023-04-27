using Bank_AutomationProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Test
{
    public  class HomePageTest:BasePage
    {
        LoginPage Lp;
        HomePage Hp;
        [SetUp]
        public void Setup()
        {
            Initialization();
            Lp = new LoginPage();
            Hp = Lp.Login("mngr494494", "rYzanYv");
        }

        [Test]
        public void VerfiyHomePageTitleTest()
        {
            string ActualHomePageTitle=Hp.GetTheHomePageTitle();
            Assert.AreEqual("Guru99 Bank Manager HomePage", ActualHomePageTitle);
        }
        [Test]
        public void VerfiyHomePageWelcomeTextTest()
        {
            string ActualHomePageWelcomeText = Hp.GetTheHomePageWelcomeText();
            Assert.AreEqual("Welcome To Manager's Page of Guru99 Bank", ActualHomePageWelcomeText);
        }
        [Test]
        public void VerfiyHomePageImageIsDisplayed()
        {
            Assert.IsTrue(Hp.VerifyTheWelcomePageImageIsDisplayed());
        }
        [TearDown]
        public void TearDown()
        {
            CloseBrowserWindow();
        }

    }
}
