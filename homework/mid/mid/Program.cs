using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            double c, d;
            c = double.Parse(a);
            d = double.Parse(b);

            double res;
            res = (c + d) / 2;

            Console.WriteLine("Среднее арифметическое: " + res);
        }
    }
}
