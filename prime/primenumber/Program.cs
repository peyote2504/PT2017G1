﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static bool check(int a) // создаем функцию, которая будет проверять числа на простоту
        {
            for (int i = 2; i < a; i++) // пробегаемся i от до а
            {
                if (a % i == 0)
                    return false;
            }
            if (a == 1)
                return false;
            return true; 
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // вводим числа
            string[] arr = s.Split(); // разделяем все заданные числа 
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                string t = arr[i];
                int q = int.Parse(t); // преобразовываем все в integer
                if (check(q)) // с помощью функции проверяем число
                    Console.WriteLine(t + ' '); // выводим все простые числа
            }
            Console.ReadKey();

        }
    }
}