using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minprime
{
    class Program
    {
        public static bool isPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;

        }
        public static void MinPrime() //создаем функцию минпрайм
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\111.txt"); //считываем файл
            StreamWriter sw = new StreamWriter(@"C:\Users\Asus\Desktop\1.txt"); //записываем результат в другой текстовый файл
            string[] arr = sr.ReadLine().Split(); //создаем массив и рзбиваем на подстроки
            int min = 320000; 
            foreach (string a in arr) //пробегаемся по массиву
            {
                int b = int.Parse(a); //преобразуем строку в целое число с помощью Parse
                if (b < min && isPrime(b))
                    min = b;

            }

            sw.WriteLine("The smallest Prime Number is:" + min);
            sw.Close();
            sr.Close();

        }


        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}