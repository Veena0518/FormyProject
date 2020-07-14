using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormyProject
{
    public class Features
    {
        IWebDriver driver;

        private By checkBoxHome;
        private By checkBoxHeader;
        private By checkBox1;
        private By checkBox2;
        private By checkBox3;

        private By radioHome;
        private By radioHeader;
        private By radioButton1;
        private By radioButton2;
        private By radioButton3;

        private By dateHome;
        private By dateHeader;
        private By datePickerBox;

        private By dropDownHome;
        private By dropDownHeader;
        private By dropDownButton;
        private By dropDownItemFileUpload;

        private By fileUploadHome;
        private By fileUploadHeader;
        private By fileUploadField;
        private By fileResetButton;

        private By keyBoardHome;
        private By keyBoardHeader;
        private By keyBoardTextBox;
        private By keyBoardButton;

        private By autoCompleteHome;
        private By autoCompleteHeader;
        private By autoCompleteTextBox;

        private By scrollHome;
        private By scrollHeader;
        private By scroolNameTextBox;
        private By scrollDateTextBox;

        private By switchWindowHome;
        private By switchWindowHeader;
        private By openNewTabButton;
        private By openAlertButton;

        private By modalHome;
        private By modalHeader;
        private By modalOpenButton;
        private By modalCloseButton;

        private By dragDropHome;
        private By dragDropHeader;
        private By dragImage;
        private By dragDropBox;

        public IWebElement CheckBox1 { get { return this.driver.FindElement(checkBox1); } }
        public IWebElement CheckBox2 { get { return this.driver.FindElement(checkBox2); } }
        public IWebElement CheckBox3 { get { return this.driver.FindElement(checkBox3); } }
        
        public IWebElement CheckBoxHome { get { return this.driver.FindElement(checkBoxHome); } }

        public IWebElement CheckBoxHeader { get { return this.driver.FindElement(checkBoxHeader); } }
        public IWebElement RadioHome { get { return this.driver.FindElement(radioHome); } }
        public IWebElement RadioHeader { get { return this.driver.FindElement(radioHeader); } }
        public IWebElement RadioButton1 { get { return this.driver.FindElement(radioButton1); } }
        public IWebElement RadioButton2 { get { return this.driver.FindElement(radioButton2); } }
        public IWebElement RadioButton3 { get { return this.driver.FindElement(radioButton3); } }

        public IWebElement DateHome { get { return this.driver.FindElement(dateHome); } }
        public IWebElement DateHeader { get { return this.driver.FindElement(dateHeader); } }
        public IWebElement DatePickerBox { get { return this.driver.FindElement(datePickerBox); } }

        public IWebElement DropDownHome { get { return this.driver.FindElement(dropDownHome); } }
        public IWebElement DropDownHeader { get { return this.driver.FindElement(dropDownHeader); } }
        public IWebElement DropDownButton { get { return this.driver.FindElement(dropDownButton); } }
        public IWebElement DropDownItemFileUpload { get { return this.driver.FindElement(dropDownItemFileUpload); } }
        public IWebElement FileUploadHome { get { return this.driver.FindElement(fileUploadHome); } }
        public IWebElement FileUploadHeader { get { return this.driver.FindElement(fileUploadHeader); } }
        public IWebElement FileUploadField { get { return this.driver.FindElement(fileUploadField); } }
        public IWebElement FileUploadResetButton { get { return this.driver.FindElement(fileResetButton); } }
        public IWebElement KeyBoardHome { get { return this.driver.FindElement(keyBoardHome); } }
        public IWebElement KeyBoardHeader { get { return this.driver.FindElement(keyBoardHeader); } }
        public IWebElement KeyBoardTextBox { get { return this.driver.FindElement(keyBoardTextBox); } }
        public IWebElement KeyBoardButton { get { return this.driver.FindElement(keyBoardButton); }}

        public IWebElement AutoCompleteHome { get { return this.driver.FindElement(autoCompleteHome); } }
        public IWebElement AutoCompleteHeader { get { return this.driver.FindElement(autoCompleteHeader); } }
        public IWebElement AutoCompleteTextBox { get { return this.driver.FindElement(autoCompleteTextBox); } }

        public IWebElement ScrollHome { get { return this.driver.FindElement(scrollHome); } }
        public IWebElement ScrollHeader { get { return this.driver.FindElement(scrollHeader); } }
        public IWebElement ScrollNameTextBox { get { return this.driver.FindElement(scroolNameTextBox); } }
        public IWebElement ScrollDateTextBox { get { return this.driver.FindElement(scrollDateTextBox); } }

        public IWebElement SwitchWindowHome { get { return this.driver.FindElement(switchWindowHome); } }
        public IWebElement SwitchWindowHeader { get { return this.driver.FindElement(switchWindowHeader); } }
        public IWebElement OpenNewTabButton { get { return this.driver.FindElement(openNewTabButton); } }
        public IWebElement OpenAlertButton { get { return this.driver.FindElement(openAlertButton); } }

        public IWebElement ModalHome { get { return this.driver.FindElement(modalHome); } }
        public IWebElement ModalHeader { get { return this.driver.FindElement(modalHeader); } }
        public IWebElement ModalOpenButton { get { return this.driver.FindElement(modalOpenButton); } }
        public IWebElement ModalCloseButton { get { return this.driver.FindElement(modalCloseButton); } }

        public IWebElement DragDropHome { get { return this.driver.FindElement(dragDropHome); } }
        public IWebElement DragDropHeader { get { return this.driver.FindElement(dragDropHeader); } }
        public IWebElement DragImage { get { return this.driver.FindElement(dragImage); } }
        public IWebElement DragDropBox { get { return this.driver.FindElement(dragDropBox); } }

        //public IWebElement RadioButton3 { get { return this.driver.FindElement(radioButton3); } }



        //helper method to find elements
        private void Init()
        {
            checkBoxHome = By.XPath("/html/body/div/div/li[3]/a");
            checkBoxHeader = By.XPath("/html/body/div/h1");
            checkBox1 = By.Id("checkbox-1");
            checkBox2 = By.Id("checkbox-2");
            checkBox3 = By.Id("checkbox-3");

            radioHome = By.XPath("/html/body/div/div/li[12]/a");
            radioHeader = By.XPath("/html/body/div/h1");
            radioButton1 = By.Id("radio-button-1");
            radioButton2 = By.CssSelector("input[value='option2']");
            radioButton3 = By.CssSelector("input[value='option3']");

            dateHome = By.XPath("/html/body/div/div/li[4]/a");
            dateHeader = By.XPath("/html/body/div/h1");
            datePickerBox = By.Id("datepicker");

            dropDownHome = By.XPath("/html/body/div/div/li[6]/a");
            dropDownHeader = By.XPath("/html/body/div/h1");
            dropDownButton = By.Id("dropdownMenuButton");
            dropDownItemFileUpload = By.XPath("/html/body/div/div/div/a[8]");

            fileUploadHome = By.XPath("/html/body/div/div/li[8]/a");
            fileUploadHeader = By.XPath("/html/body/div/h1");
            fileUploadField = By.Id("file-upload-field");
            fileResetButton = By.XPath("//*[@class='btn btn-warning btn-reset']");

            keyBoardHome = By.XPath("/html/body/div/div/li[9]/a");
            keyBoardHeader = By.XPath("/html/body/div/h1");
            keyBoardTextBox = By.Id("name");
            keyBoardButton = By.Id("button");

            autoCompleteHome = By.XPath("//a[@class='btn btn-lg'][contains(text(),'Autocomplete')]");
            autoCompleteHeader = By.XPath("/html/body/div[1]/h1");
            autoCompleteTextBox = By.Id("autocomplete");

            scrollHome = By.XPath("/html/body/div/div/li[11]/a");
            scrollHeader = By.XPath("/html/body/div/h1");
            scroolNameTextBox = By.Id("name");
            scrollDateTextBox = By.Id("date");

            switchWindowHome = By.XPath("/html/body/div/div/li[13]/a");
            switchWindowHeader = By.XPath("/html/body/div/h1");
            openNewTabButton = By.Id("new-tab-button");
            openAlertButton = By.Id("alert-button");

            modalHome = By.XPath("//a[@class='btn btn-lg'][contains(text(),'Modal')]");
            modalHeader = By.XPath("//h1[contains(text(),'Modal')]");
            modalOpenButton = By.Id("modal-button");
            modalCloseButton = By.Id("close-button");

            dragDropHome = By.XPath("//a[@class='btn btn-lg'][contains(text(),'Drag and Drop')]");
            dragDropHeader = By.XPath("//h1[contains(text(),'Drag the image into the box')]");
            dragImage = By.XPath("//div[@id='image']//img");
            dragDropBox = By.Id("box");
            //autoCompleteHeader = By.XPath("/html/body/div[1]/h1");
            //autoCompleteTextBox = By.Id("autocomplete");
            //fileResetButton = By.XPath("//*[@class='btn btn-warning btn-reset']");
        }
        public Features(IWebDriver driver)
        {
            this.driver = driver;
            //calls Init method
            this.Init();
        }
    }
}
