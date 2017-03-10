using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            string n = Console.ReadLine();
            int p = Int32.Parse(n);
            while (p>0)
            {
                s = s + (p % 10);
                p = p / 10;   
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
