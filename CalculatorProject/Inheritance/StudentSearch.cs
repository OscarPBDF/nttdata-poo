using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorProject.Inheritance
{
    public class StudentSearch
    {

        public static List<Student> FindStudent(List<Student> students)
        {
            IEnumerable<Student> studentFind =
               from student in students
               where student.age > 30
               && (student.name.ToCharArray()[0] == 'S')
               && (student.address.city.Equals("Madrid"))
               select student;
            return studentFind.ToList();
        }
    }
}
