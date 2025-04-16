using OpenQA.Selenium;
using SauceDemo.Testing_SpecFlow.Resources.Common;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SauceDemo.Testing_SpecFlow.Pages_POM
{
    [Binding]
    public class LoginPage : Base
    {
       #region Methods

        public void NavigateToUrl()
        {
            string url = ConfigurationManager.AppSettings["Url"];
            getDriver().Navigate().GoToUrl(url);
            getDriver().Manage().Window.Maximize();
        }

        public void EnterCredentials(string username, string password)
        {
            getDriver().FindElement(By.Id("user-name")).SendKeys(username);
            getDriver().FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            getDriver().FindElement(By.Id("login-button")).Click();
        }

        

        #endregion
    }
}
