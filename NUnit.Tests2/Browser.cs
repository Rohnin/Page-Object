using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnit.Tests2
{
    public class Browser
    {
        public Browser TurnOn()
        {
            IWebDriver driver = new ChromeDriver();
            return this;
        }
    }
}
