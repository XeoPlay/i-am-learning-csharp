using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
