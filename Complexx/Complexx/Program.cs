using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexx
{

    class Complex //создаем класс
    {
        int a, b;
        public Complex(int a, int b) //создаем конструктор
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString() //переопределение функции в тюстринг
        {
            return this.a + "/" + this.b;
        }
        public static Complex operator +(Complex a, Complex b)  //выполняет операцию для двух дробей
        {
            return new Complex(a.a * b.b + b.a * a.b, a.b * b.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(5, 4);
            Complex b = new Complex(2, 3);
            Console.WriteLine(a + b); //выводим данные на экран
            Console.ReadKey();
        }
    }
}