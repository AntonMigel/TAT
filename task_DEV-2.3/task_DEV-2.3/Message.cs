using OpenQA.Selenium;

namespace task_DEV_2._3
{
    class Message
    {
        string WRITEMESSAGEBUTTON = "";
        string WHOMESSAGE = "";
        string TEXTMESSAGE = "";
        string BUTTONSEND = "";

        const string INPUT_TEXT = "HELLO";
        IWebDriver _driver;
        
        public Message(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public Message WriteMessage(string email)
        {
           _driver.FindElement(By.XPath(WRITEMESSAGEBUTTON)).Click();
           _driver.FindElement(By.XPath(WHOMESSAGE)).SendKeys(email);
           _driver.FindElement(By.XPath(TEXTMESSAGE)).SendKeys(INPUT_TEXT);
           _driver.FindElement(By.XPath(BUTTONSEND)).Click();
            return this;
        }
    }
}
