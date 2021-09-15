using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AuthorisationCianPageTests.PageObject
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _signInButton = By.XPath("//a[@id='login-btn']");
        private readonly By _userLogin = By.CssSelector(".c-header-user-login-full");
        private readonly By _personalAccountButton = By.XPath("//img[@class = 'user-avatar']");


        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AutorizationPageObject SingIn()
        {
            _webDriver.FindElement(_signInButton).Click();

            return new AutorizationPageObject(_webDriver);
        }
        /*public String GetUserLogin()
        {
            string userLogin = _webDriver.FindElement(_userLogin).Text;
            return userLogin;
        }*/
    }
}
