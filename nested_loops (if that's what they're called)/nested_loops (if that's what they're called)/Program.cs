using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loops__if_that_s_what_they_re_called_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 10; a++)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        Console.WriteLine(a + " " + i + " " + l); // i thik i accidentaly made a program that writes down all the 3-digit numbers lol
                    }
                }
            }
        }
    }
}
