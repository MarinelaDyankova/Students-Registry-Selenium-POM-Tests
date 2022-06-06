using NUnit.Framework;

namespace Students_Registry_Selenium_POM_Tests
{
    public class TestViewStudentsPage:BaseTest
    {
       

        [Test]
        public void Test_ViewStudentsPage_Content()
        {
            var page = new ViewStudentsPage(driver);
            page.Open();
            Assert.AreEqual("Students", page.GetPageTitle());
            Assert.AreEqual("Registered Students", page.GetPageHeading());
        }

        [Test]
        public void Test_Check_Students()
        {
            var page = new ViewStudentsPage(driver);
            page.Open();
            var students=page.GetRegisteredStudents();
            foreach (var student in students)
            {
                Assert.IsTrue(student.IndexOf("(") > 0);
                Assert.IsTrue(student.LastIndexOf(")") == student.Length - 1);
            }
        }
        [Test]
        public void Test_HomePage_Links()
        {
            var homePage = new ViewStudentsPage(driver);
            homePage.Open();
            homePage.LinkHomePage.Click();
            Assert.IsTrue(new HomePage(driver).IsOpen());

        }
        [Test]
        public void Test_AddStudent_Links()
        {
            var homePage = new ViewStudentsPage(driver);
            homePage.Open();
            homePage.LinkAddStudentsPage.Click();
            Assert.IsTrue(new AddStudentPage(driver).IsOpen());

        }
        [Test]
        public void Test_ViewStudents_Links()
        {
            var homePage = new ViewStudentsPage(driver);
            homePage.Open();
            homePage.LinkViewStudentsPage.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).IsOpen());

        }
    }
}