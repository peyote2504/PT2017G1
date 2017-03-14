using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public class Complex
    {
        public int a, b;
        public Complex() { }
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
        public static void Save(int x, int y)
        {
            File.Delete("1.xml");
            FileStream fs = new FileStream("1.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex c = new Complex(x, y) ;
            xs.Serialize(fs, c);
            fs.Close();
        }
        public static void Resume ()
        {
            FileStream fs = new FileStream("1.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex c = (Complex)xs.Deserialize(fs);
            Console.WriteLine(c);
            fs.Close();
        }
        static void Main(string[] args)
        {
            Complex a = new Complex(5, 3), b = new Complex(2, 2);
            Console.WriteLine(a + b);
            Complex c = a + b;
            Save(c.a, c.b);
            Resume();
            Console.ReadKey();

        }
    }
}
