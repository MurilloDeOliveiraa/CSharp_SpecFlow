using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDemo.Testing_SpecFlow.Resources.Steps
{
    [Parallelizable(ParallelScope.All)]
    public class TestSteps
    {
        
        [Test, Category("Regression")]
        public void NavigateToGloboSite()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globo.com");
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
