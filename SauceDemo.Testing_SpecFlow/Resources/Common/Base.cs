using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;

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
