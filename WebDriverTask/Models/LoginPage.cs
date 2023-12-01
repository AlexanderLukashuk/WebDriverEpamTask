using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverTask.Models
{
    public class LoginPage
    {
        private readonly IWebDriver webDriver;

        public LoginPage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public IWebElement EmailInput => webDriver.FindElement(By.Id("email"));

        public IWebElement PasswordInput => webDriver.FindElement(By.Id("password"));

        public IWebElement LoginButton => webDriver.FindElement(By.Id("loginButton"));

        public void Login(string email, string password)
        {
            EmailInput.SendKeys(email);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }
    }
}