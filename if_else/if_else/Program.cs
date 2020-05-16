using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double input1 = double.Parse(input);

            if (input1 > 4)
            {
                Console.WriteLine("Number is more than 4");
            }
            else if (input1 < 4)
            {
                Console.WriteLine("Number is less than 4");
            }
            else
            {
                Console.WriteLine("Number is equal to 4");
            }
        }
    }
}
