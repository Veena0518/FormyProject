using FormyProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace FormyTests
{
    [TestClass]
    public class FormyTests
    {
        OpenAndClose setup;
        IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            setup = new OpenAndClose();
            driver = setup.Open(null);
        }
       
        [TestCleanup]
        public void TearDown()
        {
            setup.Close();
        }
        [TestMethod]
        public void TestTitleAndLogo()
        {
            var title = new TitleAndLogo(driver);

            Assert.AreEqual("Formy", driver.Title, "Title does not match");
            Assert.AreEqual("FORMY", title.Logo.Text, "Can't find Logo");
        }

        [TestMethod]
        public void TestCheckBoxes()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on checkbox from home
            features.CheckBoxHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Checkboxes", features.CheckBoxHeader.Text, "Header does not match");
            //clicks on check boxes 1 and 3
            features.CheckBox1.Click();
            features.CheckBox3.Click();
        }

        [TestMethod]
        public void TestRadioButtons()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on radiobutton from home
            features.RadioHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Radio buttons", features.RadioHeader.Text, "Header does not match");
            //clicks on radio buttons 2 and 3
            features.RadioButton2.Click();
            features.RadioButton3.Click();
        }

        [TestMethod]
        public void TestDatePicker()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on datepicker from home
            features.DateHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Datepicker", features.DateHeader.Text, "Header does not match");
            //sends date in datepicker and clicks enter
            features.DatePickerBox.SendKeys("11/24/2020" + Keys.Enter);
        }

        [TestMethod]
        public void TestDropDown()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on dropdown from home
            features.DropDownHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Dropdown", features.DropDownHeader.Text, "Header does not match");
            //clicks on drop down menu and clicks on fileupload 
            features.DropDownButton.Click();
            features.DropDownItemFileUpload.Click();
        }

        [TestMethod]
        public void TestFileUpload()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on fileupload from home
            features.FileUploadHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("File upload", features.FileUploadHeader.Text, "Header does not match");
            //sends image to file upload and then clicks on reset button
            features.FileUploadField.SendKeys("14-Venice.jpg");
            features.FileUploadResetButton.Click();
        }

        [TestMethod]
        public void TestKeyBoardMouseInput()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on KeyboardMouseInput from home
            features.KeyBoardHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Keyboard and Mouse Input", features.KeyBoardHeader.Text, "Header does not match");
            //sends input in text box and clicks on button
            features.KeyBoardTextBox.Click();
            features.KeyBoardTextBox.SendKeys("Cheese Sandwich!!");
            features.KeyBoardButton.Click();
        }

        [TestMethod]
        public void TestAutocomplete()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on Autocomplete from home
            features.AutoCompleteHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Autocomplete", features.AutoCompleteHeader.Text, "Header does not match");
            //sends input in Address text box 
            features.AutoCompleteTextBox.Click();
            features.AutoCompleteTextBox.SendKeys("4911 Tacoma Mall Blvd, Tacoma, WA, USA" +Keys.Enter);
        }

        [TestMethod]
        public void TestScroll()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on Scroll from home
            features.ScrollHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Large page content", features.ScrollHeader.Text, "Header does not match");
            //sends input in Name and Date text box 
            var name = features.ScrollNameTextBox;
            //actions will scroll down the page and select the element
            Actions actions = new Actions(driver);
            actions.MoveToElement(name);
            name.Click();
            name.SendKeys("John Sanders");
            var date = features.ScrollDateTextBox;
            date.Click();
            date.SendKeys("09/07/2016");
        }

        [TestMethod]
        public void TestSwitchWindow()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on SwitchWindow from home
            features.SwitchWindowHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Switch Window", features.SwitchWindowHeader.Text, "Header does not match");
            //clicks on new tab button 
            string originalHandle = driver.CurrentWindowHandle;
            var newTab = features.OpenNewTabButton;
            newTab.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Formy", driver.Title, "Title does not match");
            string newHandle1 = driver.WindowHandles[1];
            //closes the new window
            driver.SwitchTo().Window(newHandle1).Close();
            //switches back to original window
            driver.SwitchTo().Window(originalHandle);
            Thread.Sleep(2000);
            //clicks on Open alert 
            features.OpenAlertButton.Click();
            //Goes to Alert window and clicks Ok
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [TestMethod]
        public void TestModal()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on Modal from home
            features.ModalHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Modal", features.ModalHeader.Text, "Header does not match");
            //Clicks on OpenModal button 
            features.ModalOpenButton.Click();
            Thread.Sleep(2000);
            //Goes to Modal window and clicks on Close button
            var closeButton = features.ModalCloseButton;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", closeButton);
        }

        [TestMethod]
        public void TestDragDropBox()
        {
            var features = new Features(driver);
            Thread.Sleep(2000);
            //clicks on DragDrop from home
            features.DragDropHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Drag the image into the box", features.DragDropHeader.Text, "Header does not match");
            var image = features.DragImage;
            var box = features.DragDropBox;
            Thread.Sleep(1000);
            //drags the image and puts in drop box
            Actions actions = new Actions(driver);
            actions.DragAndDrop(image, box).Build().Perform();
        }

        [TestMethod]
        public void TestCompleteWebForm()
        {
            var form = new Form(driver);
            Thread.Sleep(2000);
            //clicks on CompletWebForm from home
            form.FormHome.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Complete Web Form", form.FormHeader.Text, "Header does not match");
            form.FirstName.SendKeys("Abraham");
            form.LastName.SendKeys("Lincoln");
            form.JobTitle.SendKeys("SDET");
            form.EducationGradSchool.Click();
            form.SexMale.Click();
            Thread.Sleep(1000);
            form.Experience5To9.Click();
            form.Date.SendKeys("10/15/2022");
            form.SubmitButton.Click();
            Thread.Sleep(2000);
            Assert.AreEqual("Thanks for submitting your form", form.FormSubmissionHeader.Text, "Header does not match");
            Assert.AreEqual("The form was successfully submitted!", form.FormSubmissionAlert.Text, "Alert does not match");
        }
    }
}
