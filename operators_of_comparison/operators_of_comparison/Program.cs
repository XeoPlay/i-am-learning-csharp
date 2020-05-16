using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace operators_of_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            double c = Convert.ToDouble(a);
            double d = Convert.ToDouble(b);

            bool res1 = c == d;
            bool res2 = c != d;
            bool res3 = c <= d;
            bool res4 = c >= d;
            bool res5 = c > d;
            bool res6 = c < d;

            Console.WriteLine("a == b: " + res1); 
            Console.WriteLine("a != b: " + res2);
            Console.WriteLine("a <= b: " + res3);
            Console.WriteLine("a >= b: " + res4);
            Console.WriteLine("a > b: " + res5); 
            Console.WriteLine("a < b: " + res6); 
        }
    }
}
