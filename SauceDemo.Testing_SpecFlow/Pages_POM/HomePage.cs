using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SauceDemo.Testing_SpecFlow.Resources.Common;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDemo.Testing_SpecFlow.Pages_POM
{
    internal class HomePage 
    {
        IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='inventory_item'][1]/div/div/button")]
        private IWebElement FirstItem;

        [FindsBy(How = How.XPath, Using = "//div[@class='inventory_item'][2]/div/div/button")]
        private IWebElement SecondItem;

        [FindsBy(How = How.CssSelector, Using = ".product_sort_container")]
        private IWebElement dropDown;



        public void CheckTitle()
        {
            string expectedValue = "Products";
            string currentValue = Driver.FindElement(By.XPath("//span[@class='title']")).Text.Trim();

            Assert.AreEqual(expectedValue, currentValue);
            TestContext.Progress.WriteLine("Message correctly validated!");
        }

        public void SortProductsByPrice()
        {
            SelectElement s = new SelectElement(dropDown);
            s.SelectByValue("hilo");

            String expectedPrice = "$49.99";
            String currentPrice = Driver.FindElement(By.XPath("//div[@class='inventory_item'][1]/div/div/div[@class='inventory_item_price']")).Text;
            Assert.AreEqual(expectedPrice, currentPrice);
                        
            Actions act = new Actions(Driver);
            IWebElement lastItemPrice = Driver.FindElement(By.XPath("//div[@class='inventory_item'][6]/div/div/div[@class='inventory_item_price']"));
            act.ScrollToElement(lastItemPrice).Perform();

            String expectedPrice2 = "$7.99";
            String currentPrice2 = Driver.FindElement(By.XPath("//div[@class='inventory_item'][6]/div/div/div[@class='inventory_item_price']")).Text;

            Assert.AreEqual(expectedPrice2, currentPrice2);
            Thread.Sleep(3000);

            IWebElement titleText = Driver.FindElement(By.CssSelector(".title"));
            act.ScrollToElement(titleText).Perform();
        }

        public void AddProductToCart(int quant)
        {
            if (quant <= 1)
            {
               FirstItem.Click();
            }
            else
            {
                FirstItem.Click();
                SecondItem.Click();                
            }            
        }
    }
}
