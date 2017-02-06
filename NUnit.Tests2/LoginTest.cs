using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NUnit.Tests2
{
    [TestFixture]
    public class LoginTest
    {
        #region TestData
        string test_url = "http://www.4programmers.net/Login";
        string login = "Test10";
        string password = "test5001";
        #endregion

        [Test]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();

            var LoginPage = new PageObject();
            PageFactory.InitElements(driver, LoginPage);
            LoginPage.LoginPage(login, password);
            LoginPage.Logout();
            driver.Close();
        }
    }
}
