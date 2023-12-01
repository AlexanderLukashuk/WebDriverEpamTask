using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverTask.Models
{
    public class AccountSettingsPage
    {
        private readonly IWebDriver webDriver;

        public AccountSettingsPage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public IWebElement NicknameInput => webDriver.FindElement(By.Id("nickname"));

        public IWebElement SaveButton => webDriver.FindElement(By.Id("saveButton"));

        public void ChangeNickname(string newNickname)
        {
            NicknameInput.Clear();
            NicknameInput.SendKeys(newNickname);
            SaveButton.Click();
        }
    }
}