using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse_tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1";
            int a;
            bool res = int.TryParse(str, out a);
            if (res)
            {
                Console.WriteLine("найс");
            }
            else
            {
                Console.WriteLine("ненайс");
            }
        }
    }
}
