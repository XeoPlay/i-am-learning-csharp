using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumof3_multof3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            double d, e, f;
            d = double.Parse(a);
            e = double.Parse(b);
            f = double.Parse(c);

            double g, h;
            g = d + e + f;
            h = d * e * f;

            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
