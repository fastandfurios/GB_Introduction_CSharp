using System;

namespace Task_3_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1 задача

			int[,] array = { {1, 2, 3}, {4, 5, 6} };
			string space = string.Empty;

			foreach (int item in array)
			{
				Console.WriteLine(space + item);
				space += " ";
			}

			Console.ReadLine();
		}
	}
}
