using AuthorisationCianPageTests.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AuthorisationCianPageTests
{
    public class Tests
    {
        IWebDriver _webDriver = new ChromeDriver();
        
        private const string _login = "golovindanil28@gmail.com";
        private const string _password = "Danil2693";

        [SetUp]
        public void Setup()
        {


            _webDriver.Navigate().GoToUrl("https://cian.ru");
            _webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
                .SingIn()
                .Login(_login, _password);
            Thread.Sleep(2000);
            //string logintest = mainMenu.GetUserLogin();
            //Assert.AreEqual(_login, logintest, "Login is wrong or wasn't completed");
        }
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}