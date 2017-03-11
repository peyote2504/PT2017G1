using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"C:\Users\Asus\Desktop\121.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Complex a = new Complex(5, 3), b = new Complex(2, 2);
            Complex c = new Complex(1, 1);
            bf.Serialize(f, c);
            c = a + b;
            Console.WriteLine(c);
            bf = new BinaryFormatter();
            f.Close();
            f = new FileStream(@"C:\Users\Asus\Desktop\121.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            c = bf.Deserialize(f) as Complex;
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
