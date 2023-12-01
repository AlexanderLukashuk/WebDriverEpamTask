using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverTask.Models
{
    public class ReadMailPage
    {
        private readonly IWebDriver webDriver;

        public ReadMailPage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public IWebElement ReplyButton => webDriver.FindElement(By.Id("replyButton"));

        public IWebElement Sender => webDriver.FindElement(By.ClassName("sender"));

        public IWebElement Content => webDriver.FindElement(By.ClassName("content"));

        public void ReplyWithnewAlias(string alias)
        {
            
        }
    }
}