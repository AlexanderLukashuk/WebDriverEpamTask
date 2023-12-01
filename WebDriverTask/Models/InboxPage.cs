using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverTask.Models
{
    public class InboxPage
    {
        private readonly IWebDriver webDriver;

        public InboxPage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public IWebElement ComposeButton => webDriver.FindElement(By.Id("composeButton"));
        
        public IWebElement SentItemsLink => webDriver.FindElement(By.Id("sentItemLink"));
    }
}