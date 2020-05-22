using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 13, 25, 7, 6, 57, 78 };
            Array.Sort(myArray); // 6 7 13 25 57 78
            Array.Reverse(myArray); // 78 57 25 13 7 6
            int sum = myArray.Sum(); // 78 + 57 + 25 + 13 + 7 + 6
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]); //prints out "78 57 25 13 7 6"
            }
            Console.WriteLine(sum); //prints out "186"
        }
    }
}
