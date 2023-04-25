using Bank_AutomationProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AutomationProject.Test
{
    public class LoginTest : BasePage
    {
        LoginPage Lp;

        [SetUp]
        public void Setup()
        {
            Initialization();
            Lp = new LoginPage();      
        }

        [Test]
        public void LoginPageTest()
        {
            Lp.Login("mngr494494", "rYzanYv");
            Assert.AreEqual("Manager Id : mngr494494", Lp.GetTheLoginId());
        }
        [TearDown]
        public void TearDown()
        {
           CloseBrowserWindow();
        }
    }
}
