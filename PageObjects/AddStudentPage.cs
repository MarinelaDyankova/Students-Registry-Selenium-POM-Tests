using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Students_Registry_Selenium_POM_Tests
{
    public class AddStudentPage:BasePage
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";

        public IWebElement ErrElementErrorMsg => (IWebElement)driver.FindElements(By.CssSelector("body > div"));
        public IWebElement FieldStudentName => (IWebElement)driver.FindElements(By.CssSelector("#name"));
        public IWebElement FieldStudentEmail => (IWebElement)driver.FindElements(By.CssSelector("#email"));
        public IWebElement ButtonAdd => (IWebElement)driver.FindElements(By.CssSelector("button[type='submit']"));

        public void AddStudent(string name,string email)
        {
            this.FieldStudentName.SendKeys(name);
            this.FieldStudentEmail.SendKeys(email);
            this.ButtonAdd.Click();
        }

        

        
    }
}