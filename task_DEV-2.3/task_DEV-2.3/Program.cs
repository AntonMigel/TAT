using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace task_DEV_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mail.ru/";
            Login log = new Login(driver);
            log.LogIN("tattovich", "uA7pA3oPTah[");
            Message message = new Message(driver);
            message.WriteMessage("sghcj");
        }
    }
}
