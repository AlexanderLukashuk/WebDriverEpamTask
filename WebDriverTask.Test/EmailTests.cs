using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverTask.Models;

namespace WebDriverTask.Test
{
    [TestFixture]
    public class EmailTests
    {
        private IWebDriver webDriver;

        private LoginPage loginPage;

        private InboxPage inboxPage;

        private ComposePage composePage;

        private ReadMailPage readMailPage;

        private AccountSettingsPage accountSettingsPage;

        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://mail.google.com/");

            loginPage = new LoginPage(webDriver);
            inboxPage = new InboxPage(webDriver);
            composePage = new ComposePage(webDriver);
            readMailPage = new ReadMailPage(webDriver);
            accountSettingsPage = new AccountSettingsPage(webDriver);
        }

        [Test]
        public void LogitTest()
        {
            loginPage.Login("goslingr253@gmail.com", "SuperMegaGosling_1488");

            Assert.IsTrue(IsUserLoggedIn(), "Login was not successful");
        }

        private bool IsUserLoggedIn()
        {
            try
            {
                IWebElement inboxElement = webDriver.FindElement(By.Id("inbox"));
                return inboxElement != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}