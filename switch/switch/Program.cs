using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                    Console.WriteLine("1 or 2");
                    break;
                
                default:
                    Console.WriteLine("nor 1 nor 2");
                    break;
            }
        }
    }
}
