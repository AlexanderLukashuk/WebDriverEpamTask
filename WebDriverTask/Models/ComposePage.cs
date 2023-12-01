using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverTask.Models
{
    public class ComposePage
    {
        private readonly IWebDriver webDriver;

        public ComposePage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public IWebElement ToInput => webDriver.FindElement(By.Id("to"));

        public IWebElement SubjectInput => webDriver.FindElement(By.Id("subject"));

        public IWebElement BodyInput => webDriver.FindElement(By.Id("body"));

        public IWebElement SendButton => webDriver.FindElement(By.Id("sendButton"));

        public void ComposeAndSend(string to, string subject, string body)
        {
            ToInput.SendKeys(to);
            SubjectInput.SendKeys(subject);
            BodyInput.SendKeys(body);
            SendButton.Click();
        }
    }
}