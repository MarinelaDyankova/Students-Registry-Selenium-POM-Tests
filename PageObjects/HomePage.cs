using NUnit.Framework;
using OpenQA.Selenium;

namespace Students_Registry_Selenium_POM_Tests
{
    public class HomePage : BasePage
    {
        //•	Constructor: HomePage(IWebDriver driver) 
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        //•	Properties: inherited + PageUrl (assigned correctly) + ElementStudentsCount
        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";

        public IWebElement ElementStudentsCount => driver.FindElement(By.CssSelector("body > p > b"));

        public object ViewStudentsPage { get; internal set; }

        //•	Methods: inherited + GetStudentsCount()

        public int GetStudentsCount()
        {
            return int.Parse(ElementStudentsCount.Text);
        }


        
    }
}