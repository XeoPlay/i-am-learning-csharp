using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the first number:");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Write the second number:");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Write + - * or /");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("Result is: " + (firstNum + secondNum));
                    break;
                case "-":
                    Console.WriteLine("Result is: " + (firstNum - secondNum));
                    break;
                case "*":
                    Console.WriteLine("Result is: " + (firstNum * secondNum));
                    break;
                case "/":
                    Console.WriteLine("Result is: " + (firstNum / secondNum));
                    break;
            }
        }
    }
}
