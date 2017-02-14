using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int m;
            List<int> list = new List<int>();
            using (StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\111.txt")) //считываем данные с текстового документа
            {
                line = sr.ReadToEnd(); //Считывает все символы, начиная с текущей позиции до конца потока
            }
            string[] str = line.Split(' '); //Разбивает строку на максимальное число подстрок в зависимости от строк в массиве
            for (int i = 0; i < str.Length; i++)
            {
                m = Int32.Parse(str[i]); //превращаем все данные в инт
                list.Add(m); //добавляем все эти данные в лист
            }
            list.Sort(); //сортируем все данные

            Console.WriteLine("Max:{0} Min:{1}", list[str.Length - 1], list[0]);
            Console.ReadKey();
        }
    }
}
