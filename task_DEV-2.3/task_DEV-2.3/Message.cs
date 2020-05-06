using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace task_DEV_2._3
{
    class Message
    {
        string WRITEMESSAGEBUTTON = "//a[@title='Написать письмо']";
        string RECIPIENT = "//div[@data-name='to']/descendant::input";
        string TEXTMESSAGEBOX= "//*[@role ='textbox']";
        string BUTTONSEND = "//div[@class ='compose-app__buttons']/child::span[@title='Отправить']";
        const string INPUT_TEXT = "HELLO";
        IWebDriver _driver;
        
        public Message(IWebDriver driver)
        {
            _driver = driver;
        }
        public Message WriteMessage(string email)
        {
            IWebElement WrtieMessage = WaitUntilElementExist(WRITEMESSAGEBUTTON);
            WrtieMessage.Click();
            IWebElement Recipient = WaitUntilElementExist(RECIPIENT);
            Recipient.SendKeys(email);
            IWebElement TextMessageBox = WaitUntilElementExist(TEXTMESSAGEBOX);
            TextMessageBox.SendKeys(INPUT_TEXT);
            IWebElement ButtonSend = WaitUntilElementExist(BUTTONSEND);
            ButtonSend.Click();
            return this;
        }
        private IWebElement WaitUntilElementExist(string xpathString)
        {
            return new WebDriverWait(_driver, System.TimeSpan.FromSeconds(20))
                              .Until(ExpectedConditions.ElementExists(By.XPath(xpathString)));
        }
    }
}
