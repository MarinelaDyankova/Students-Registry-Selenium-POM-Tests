using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Students_Registry_Selenium_POM_Tests
{
    public class BasePage
    {
        //•	Field: IWebDriver driver (protected and readonly)
        protected readonly IWebDriver driver;
       
        //•	PageUrl
        public virtual string PageUrl { get; }

        //•	Constructor: BasePage(IWebDriver driver)
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;   
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(2);
        }
        //•	Properties: LinkHomePage, LinkViewStudentsPage, LinkAddStudentsPage, ElementTextHeading
        public IWebElement LinkHomePage => driver.FindElement(By.LinkText("Home"));
        public IWebElement LinkViewStudentsPage => driver.FindElement(By.LinkText("View Students"));
        public IWebElement LinkAddStudentsPage => driver.FindElement(By.LinkText("Add Student"));
        public IWebElement ElementTextHeading => driver.FindElement(By.CssSelector("body > h1"));


        //•	Method: Open() => driver.Url = this.PageUrl;
        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        //•	Method: IsOpen() => driver.Url == this.PageUrl;
        public bool IsOpen()
        {
            return driver.Url == this.PageUrl;  
        }

        //•	Methods: GetPageTitle(), GetPageHeading()
        public string GetPageTitle()
        {
            return driver.Title;
        }
        public string GetPageHeading()
        {
            return ElementTextHeading.Text;
        }
        public string GetPageUrl() 
        {
            return driver.Url;
        }
    }
}