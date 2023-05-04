using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.Testing_SpecFlow.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Testing_SpecFlow.Pages_POM
{
    internal class HomePage 
    {
        IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public void CheckTitle()
        {
            string expectedValue = "Products";
            string currentValue = Driver.FindElement(By.XPath("//span[@class='title']")).Text.Trim();

            Assert.AreEqual(expectedValue, currentValue);
            TestContext.Progress.WriteLine("Message correctly validated!");
        }
    }
}
