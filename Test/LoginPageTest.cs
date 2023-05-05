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
    public class LoginPageTest : BasePage
    {
        LoginPage Lp;
        private HomePage Hp;
        [SetUp]
        public void Setup()
        {
            Initialization();
            Lp = new LoginPage();      
        }

        [Test]
        public void LoginTest()
        {
            Hp = Lp.Login(config.GetUserId(),config.GetPassword());
            Assert.AreEqual("Manger Id : "+config.GetUserId(), Lp.GetTheLoginId());
        }
        [TearDown]
        public void TearDown()
        {
           CloseBrowserWindow();
        }
    }
}
