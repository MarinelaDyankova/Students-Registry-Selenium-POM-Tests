using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Students_Registry_Selenium_POM_Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp() 
        {
            driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();  
        }

        
    }
}