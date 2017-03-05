using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppppp
{
    class Program
    {
        static bool prime (int a)
            {
                for (int i=2; i<a; i++)
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
            string s = Console.ReadLine();
            int t = Int32.Parse(s);
            if (prime(t))
                Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}
