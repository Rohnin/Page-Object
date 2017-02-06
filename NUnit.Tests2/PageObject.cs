using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace NUnit.Tests2
{
    class PageObject
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement nameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement passwordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        private IWebElement loginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='caret']")]
        private IWebElement profileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-sign-out']")]
        private IWebElement logOff { get; set; }


        public PageObject LoginPage(string name, string password)
        {
            nameInput.SendKeys(name);
            passwordInput.SendKeys(password);
            loginButton.Click();
            return this;
        }

        public PageObject Logout()
        {
            profileDropdown.Click();
            logOff.Click();
            return this;
        }

    }
}
