using System;

namespace s_adder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "S-Adder";
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("Welcome to the S-Adder. Write the number of times you want me to repeat whatever you like." +
				"\nAfter that, write your message(s) and I will repeat them, adding the letter 's'." +
				"\nWrite 'exit' if you want to stop.");
			int times;
			bool a = int.TryParse(Console.ReadLine(), out times);
			if (a)
			{
				if (times > 0)
				{
					for (int i = 0; i < times; i++)
					{
						string msg = Console.ReadLine();
						if (msg == "exit")
						{
							Console.WriteLine("You exited the program");
							break;
						}
						else
						{
							Console.WriteLine(msg + "s");
						}
					}
				}
				else
				{
					Console.WriteLine("You entered a number that is less than 1.");
				}
					
			}
			else
			{
				Console.WriteLine("The number you entered wasn't a number");
			}
		}
	}
}
