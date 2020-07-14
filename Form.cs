using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormyProject
{
    public class Form
    {
        IWebDriver driver;

        private By formHome;
        private By formHeader;
        private By firstName;
        private By lastName;
        private By jobTitle;

        private By educationHighSchool;
        private By educationCollege;
        private By educationGradSchool;

        private By sexMale;
        private By sexFemale;
        private By sexPreferNotSay;

        private By experience01;
        private By experience24;
        private By experience59;
        private By experience10;

        private By date;
        private By submitButton;

        private By formSubmittionHeader;
        private By formSubmittionAlert;

        public IWebElement FormHome { get { return this.driver.FindElement(formHome); } }
        public IWebElement FormHeader { get { return this.driver.FindElement(formHeader); } }
        public IWebElement FirstName { get { return this.driver.FindElement(firstName); } }

        public IWebElement LastName { get { return this.driver.FindElement(lastName); } }

        public IWebElement JobTitle { get { return this.driver.FindElement(jobTitle); } }
        public IWebElement EducationHighSchool { get { return this.driver.FindElement(educationHighSchool); } }
        public IWebElement EducationCollege { get { return this.driver.FindElement(educationCollege); } }
        public IWebElement EducationGradSchool { get { return this.driver.FindElement(educationGradSchool); } }
        public IWebElement SexMale { get { return this.driver.FindElement(sexMale); } }
        public IWebElement SexFemale { get { return this.driver.FindElement(sexFemale); } }
        public IWebElement SexPreferNotSay { get { return this.driver.FindElement(sexPreferNotSay); } }
        public IWebElement ExperienceOTo1 { get { return this.driver.FindElement(experience01); } }
        public IWebElement Experience2To4 { get { return this.driver.FindElement(experience24); } }
        public IWebElement Experience5To9 { get { return this.driver.FindElement(experience59); } }
        public IWebElement Experience10Plus { get { return this.driver.FindElement(experience10); } }

        public IWebElement Date { get { return this.driver.FindElement(date); } }
        public IWebElement SubmitButton { get { return this.driver.FindElement(submitButton); } }
        public IWebElement FormSubmissionHeader { get { return this.driver.FindElement(formSubmittionHeader); } }
        public IWebElement FormSubmissionAlert { get { return this.driver.FindElement(formSubmittionAlert); } }


        //helper method to find elements
        private void Init()
        {
            formHome = By.XPath("//a[@class='btn btn-lg'][contains(text(),'Complete Web Form')]");
            formHeader = By.XPath("//h1[contains(text(),'Complete Web Form')]");
            firstName = By.Id("first-name");
            lastName = By.Id("last-name");
            jobTitle = By.Id("job-title");

            educationHighSchool = By.Id("radio-button-1");
            educationCollege = By.Id("radio-button-2");
            educationGradSchool = By.Id("radio-button-3");

            sexMale = By.Id("checkbox-1");
            sexFemale = By.Id("checkbox-2");
            sexPreferNotSay = By.Id("checkbox-3");
            
            experience01 = By.XPath("//option[contains(text(),'0-1')]");
            experience24 = By.XPath("//option[contains(text(),'2-4')]");
            experience59 = By.XPath("//option[contains(text(),'5-9')]");
            experience10 = By.XPath("//option[contains(text(),'10+')]");

            date = By.Id("datepicker");
            submitButton = By.XPath("//a[@class='btn btn-lg btn-primary']");

            formSubmittionHeader = By.XPath("//h1[contains(text(),'Thanks for submitting your form')]");
            formSubmittionAlert = By.XPath("//div[@class='alert alert-success']");
        }
        public Form(IWebDriver driver)
        {
            this.driver = driver;
            //calls Init method
            this.Init();
        }

    }
}
