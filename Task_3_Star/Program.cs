using System;

namespace Task_3_Star
{
	class Program
	{
		static void Main(string[] args)
		{
			// Задача со звездочкой

			string[,] field = new string[10,10];

			for (int i = 0; i < field.GetLength(0); i++)
			{
				for (int j = 0; j < field.GetLength(1); j++)
				{
					if (i == 2 && j >= 2 && j <= 5)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen; // Подсвечиваем корабли
						Console.Write(field[i, j] = "X"); // 1 корабль в 4 клетки
						Console.ResetColor();
					}
					else if (i >= 4 && i <= 6 && j == 2)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 3 клетки
						Console.ResetColor();
					}
					else if (i >= 7 && i <= 10 && j == 8)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 3 клетки
						Console.ResetColor();
					}
					else if (i == 1 && j >= 8 && j <= 9)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 2 клетки
						Console.ResetColor();
					}
					else if (i >= 8 && i <= 9 && j == 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 2 клетки
						Console.ResetColor();
					}
					else if (i == 4 && j >= 5 && j <= 6)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 2 клетки
						Console.ResetColor();
					}
					else if (i == 0 && j == 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 1 клетку
						Console.ResetColor();

					}
					else if (i == 8 && j == 3)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 1 клетку
						Console.ResetColor();
					}
					else if (i == 6 && j == 5)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 1 клетку
						Console.ResetColor();
					}
					else if (i == 0 && j == 6)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.Write(field[i, j] = "X"); // 1 корабль в 1 клетку
						Console.ResetColor();
					}
					else
						Console.Write(field[i,j] = "O");
				}

				Console.WriteLine();
			}
			
		}
	}
}
