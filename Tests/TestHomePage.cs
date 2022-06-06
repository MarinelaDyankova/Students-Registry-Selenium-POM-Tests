using NUnit.Framework;
using OpenQA.Selenium;

namespace Students_Registry_Selenium_POM_Tests
{
    public class TestHomePage : BaseTest
    {

        [Test]
        public void Test_HomePage_Content()
        {
            var page = new HomePage(driver);
            page.Open();
            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(page.GetPageHeading(), Is.EqualTo("Students Registry"));
            Assert.Greater(page.GetStudentsCount(), 0);
        }

        [Test]
        public void Test_HomePage_Links()
        {
            var homePage=new HomePage(driver);  
            homePage.Open();    
            homePage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());

        }
        [Test]
        public void Test_AddStudent_Links()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());

        }
        [Test]
        public void Test_ViewStudents_Links()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).IsOpen());

        }
    }
}