using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fake_value_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у вас долларов?");
            string str = Console.ReadLine();
            double a = double.Parse(str);
            Console.WriteLine("Это " + a * 72 + " рублей (курс ровно 72 рубля)");
        }
    }
}
