using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortened_operators_of_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int fanspeed = 0;
            bool isHighTemp = true;
            bool hasNoCooling = fanspeed <= 0;

            if (isHighTemp || hasNoCooling)
            {
                Console.WriteLine("Proccesor could be overheated");
            }
        }
    }
}
