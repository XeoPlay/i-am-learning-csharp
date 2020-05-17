using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                string msg = Console.ReadLine();
                
                if (msg == "exit")
                {
                    break;
                }
            }

        }
    }
}
