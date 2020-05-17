using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed = false;

            string storedPassword = "qwerty";
            string enteredPassword;

            while (accessAllowed == false)
            {
                enteredPassword = Console.ReadLine();
                accessAllowed = (storedPassword == enteredPassword) ? true : false;
                if (accessAllowed == false)
                {
                    Console.WriteLine("nope");
                }
            }

            Console.WriteLine("u guessed it");
        }
    }
}
