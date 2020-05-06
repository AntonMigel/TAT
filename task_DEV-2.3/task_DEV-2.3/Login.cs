using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
            IWebElement login = WaitUntilElementExist(LOGIN);
            login.SendKeys(Login);
            IWebElement loginbutton = WaitUntilElementExist(BUTTON);
            loginbutton.Click();
            IWebElement password = WaitUntilElementExist(PASSWORD);
            password.SendKeys(Password);
            IWebElement passwordbutton = WaitUntilElementExist(BUTTON);
            passwordbutton.Click();
            return this;
        }
        private IWebElement WaitUntilElementExist(string xpathString)
        {
            return new WebDriverWait(_driver, System.TimeSpan.FromSeconds(20))
                              .Until(ExpectedConditions.ElementExists(By.XPath(xpathString)));
        }
    }
}
