using AngleSharp.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Testing_SpecFlow.Pages_POM
{
    public class CheckoutPage
    {
        IWebDriver Driver;
        public CheckoutPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".shopping_cart_link .shopping_cart_badge")]
        private IWebElement numberOFProdctsOnCartButton;

        public void CheckNumberOfProductsOnCart(int productsAdded)
        {
            int currentNumberOfProducts = numberOFProdctsOnCartButton.Text.ToInteger(0);
            Assert.AreEqual(productsAdded, currentNumberOfProducts);
        }
    }
}
