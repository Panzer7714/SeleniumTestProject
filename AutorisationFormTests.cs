using AuthorisationCianPageTests.PageObject;
using NUnit.Framework;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Allure.Attributes;
using System;
using System.Threading;

namespace AuthorisationCianPageTests
{
    [TestFixture]
    [AllureNUnit]
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

        [AllureTag("Ci")]
        [AllureSeverity(Allure.Commons.SeverityLevel.critical)]
        [AllureSubSuite("Test FormAutorisation")]
        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
                .SingIn()
                .Login(_login, _password);
            //string logintest = mainMenu.GetUserLogin();
            //Assert.AreEqual(_login, logintest, "Login is wrong or wasn't completed");
        }

        [AllureSubSuite("Test2 Console Write")]
        [Test]
        public void Test2()
        {
            Console.WriteLine("Succes");
        }

        [AllureSubSuite("Test3 Console Write Fail")]
        [Test]
        public void Test3()
        {
            Console.WriteLine("3");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}