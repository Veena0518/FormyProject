using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormyProject
{
    public class TitleAndLogo
    {
        IWebDriver driver;

        //private By title;
        private By logo;

        public IWebElement Logo { get { return this.driver.FindElement(logo); } }


        //helper method to find elements
        private void Init()
        {
            //title = By.XPath("");
            logo = By.Id("logo");
        }
        public TitleAndLogo(IWebDriver driver)
        {
            this.driver = driver;
            //calls Init method
            this.Init();
        }
    }
}
