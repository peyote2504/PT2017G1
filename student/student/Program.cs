using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class student
    {
        public string name;
        public string surname;
        public int age;
        public double gpa;

        public student()
        {
            name = "Fatima";
            surname = "Askarovna";
            age = 18;
            gpa = 2.56;
        }

        public student (string name, string surname, int age, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return this.name + ' ' + this.surname + ' ' + this.age + ' ' + this.gpa;
        }
        static void Main(string[] args)
        {
            student n = new student("Asan", "Ali", 18, 2.30);
            student s = new student();
            Console.WriteLine(s.ToString());
            Console.WriteLine(n.ToString());
            Console.ReadKey();
        }
        
    }
}
