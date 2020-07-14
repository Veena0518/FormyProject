using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FormyProject
{
    public class OpenAndClose
    {
        private IWebDriver driver;

        //Google url
        private const string FormyUrl = @"http://formy-project.herokuapp.com/";

        //open method
        public IWebDriver Open(string type)
        {
            if (string.IsNullOrEmpty(type) || type == "chrome")
            {
                driver = new ChromeDriver();
            }
            driver.Navigate().GoToUrl(FormyUrl);
            return driver;
        }

        //close method
        public void Close()
        {
            driver.Quit();
        }
    }
}
