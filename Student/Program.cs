using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public double gpa;
        public Student()
        {
            name = "Fatima";
            surname = "Askarovna";
            age = 18;
            gpa = 2.56;
        }

        public Student(string name, string surname, int age, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + age + " " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Fatima", "Askarovna", 18, 2.56);
            Console.WriteLine(s.ToString());
        }
    }
}
