using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filling_arrays_with_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many positions do you want?\t");

            int pos = int.Parse(Console.ReadLine());

            int[] array = new int[pos];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter the number for array[{i}]:\t");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
