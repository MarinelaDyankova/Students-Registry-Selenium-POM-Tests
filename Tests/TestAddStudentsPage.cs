using NUnit.Framework;
using System;
using System.Linq;

namespace Students_Registry_Selenium_POM_Tests
{
    public class TestAddStudentsPage:BaseTest
    {
        

        [Test]
        public void Test_TestAddStudentPage_Content()
        {
            var page=new AddStudentPage(driver);
            page.Open();    
            Assert.AreEqual("Add Student", page.GetPageTitle());
            Assert.AreEqual("Register New Student", page.GetPageHeading());
            
            //Assert.That(page.FieldStudentName.Text,Is.EqualTo(""));
            //Assert.That(page.FieldStudentEmail.Text, Is.EqualTo(""));
            //Assert.That(page.ButtonAdd.Text, Is.EqualTo("Add"));
        }
        [Test]
        public void Test_AddStudentPage_AddValidStudent()
        {
            var page = new AddStudentPage(driver);
            page.Open();
            string name = "Pesho" + DateTime.Now.Ticks;
            string email = "Pesho" + DateTime.Now.Ticks + "@gmail.com";
            page.AddStudent(name, email);
            var view_student = new ViewStudentsPage(driver);
            Assert.IsTrue(view_student.IsOpen());
            var students = view_student.GetRegisteredStudents();
            var lastStudent = students.Last();
            string expected = name + " (" + email + ")";
            Assert.Contains(lastStudent, students);


        }
        [Test]
        public void Test_AddStudentPage_AddInValidStudent()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            string name = "";
            string email = "";
            add_Student.AddStudent(name, email);
            Assert.IsTrue(add_Student.IsOpen());
            Assert.That(add_Student.ErrElementErrorMsg.Text, Is.EqualTo("Cannot add student. Name and email fields are required!"));
        }
    }
}