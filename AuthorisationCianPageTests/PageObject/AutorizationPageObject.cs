using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthorisationCianPageTests.PageObject
{
    class AutorizationPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _loginInputButton = By.XPath("//input[@Name='username']");
        private readonly By _continueButton = By.XPath("//button[@data-mark = 'ContinueAuthBtn']");
        private readonly By _passwordInputButton = By.XPath("//input[@Name='password']");
        private readonly By _enterButton = By.XPath("//button[@data-mark = 'ContinueAuthBtn']");

        public AutorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject Login(String login, string password)
        {
            _webDriver.FindElement(_loginInputButton).SendKeys(login);
            _webDriver.FindElement(_continueButton).Click();

            Thread.Sleep(2000);
            _webDriver.FindElement(_passwordInputButton).SendKeys(password);
            _webDriver.FindElement(_enterButton).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}
