using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Student : NTTDataBase
    {
        public string name;
        public string surname;
        public DateTime birthday;
        public Address address;
        public int age;

        public Student(string name, string surname, DateTime birthday, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.address = address;
            
            age = DateTime.Now.Year - birthday.Year;
        }

    }
}
