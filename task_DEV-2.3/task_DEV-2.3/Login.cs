using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._3
{
    class Login
    {
        string LOGIN = "//input[@id='mailbox:login']";
        string BUTTON = "//*[@id='mailbox:submit']";
        string PASSWORD = "//*[@id='mailbox:password']";
        private IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }
        public Login LogIN(string Login, string Password) 
        {   
            IWebElement login = _driver.FindElement(By.XPath(LOGIN));
            login.SendKeys(Login);
            IWebElement loginbutton = _driver.FindElement(By.XPath(BUTTON));
            loginbutton.Click();
            IWebElement password = _driver.FindElement(By.XPath(PASSWORD));
            password.SendKeys(Password);
            IWebElement passwordbutton = _driver.FindElement(By.XPath(BUTTON));
            passwordbutton.Click();
            return this;
        }
    }
}
