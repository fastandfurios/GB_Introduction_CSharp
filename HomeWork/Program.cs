using System;

namespace Lesson_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите свое имя: ");
			var name = Console.ReadLine();
			Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now:G}");

			Console.ReadKey();
		}
	}
}
