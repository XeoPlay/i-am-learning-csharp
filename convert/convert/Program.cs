using System;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int inta = Convert.ToInt32(a);
            int intb = Convert.ToInt32(b);

            Console.WriteLine(inta + intb);
        }
    }
}
