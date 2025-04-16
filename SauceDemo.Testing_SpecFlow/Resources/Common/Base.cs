using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;

namespace SauceDemo.Testing_SpecFlow.Resources.Common
{
    public class Base
    {
        private WebDriver Driver;

        public IWebDriver getDriver()
        {
            return Driver;
        }


        public void CongfigBrowser()
        {
            string selectedBrowser = ConfigurationManager.AppSettings["Browser"];

            switch (selectedBrowser)
            {
               case "CHROME":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    Driver = new ChromeDriver();
                    break;
                case "EDGE":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    Driver = new EdgeDriver();
                    break;
            }
            Driver.Manage().Window.Maximize();
        }        
    }
}
