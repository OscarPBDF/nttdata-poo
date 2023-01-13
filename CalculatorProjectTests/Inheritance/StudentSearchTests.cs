using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance.Tests
{
    [TestClass()]
    public class StudentSearchTests
    {
        [TestMethod()]
        public void FindStudentTest()
        {
            Student Student1 = new Student("Jose", "Martin", DateTime.Parse("1960 / 10 / 6"), new Address("Lucera", "Barcelona", "Barcelona"));
            Student Student2 = new Student("Salba", "Gimenez", DateTime.Parse("1961 / 1 / 9"), new Address("Lucera", "Barcelona", "Barcelona"));
            Student Student3 = new Student("Maria", "Martinez", DateTime.Parse("1980 / 2 / 5"), new Address("Vallecas", "Madrid", "Madrid"));
            Student Student4 = new Student("Sergio", "Lopez", DateTime.Parse("1980 / 8 / 26"), new Address("Vallecas", "Madrid", "Madrid"));

            List<Student> students = new List<Student>();
            students.Add(Student1);
            students.Add(Student2);
            students.Add(Student3);
            students.Add(Student4);

            Assert.IsTrue(StudentSearch.FindStudent(students).Count == 1);
            Assert.IsTrue(StudentSearch.FindStudent(students)[0].name.Equals("Sergio"));
        }
    }
}