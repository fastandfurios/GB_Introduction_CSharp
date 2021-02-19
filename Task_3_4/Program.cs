using System;
using System.Reflection.Emit;

namespace Task_3_4
{
	class Program
	{
		static void Main(string[] args)
		{
			// 4 задача (дополнительная)

			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int n =  9;

			if (n < 0)
			{
				n = Math.Abs(n);

				for (int i = 0; i < array.Length; i++) // Выводим последовательность с отрицательным смещением типа 
				{                                       //3 4 5 6 7 8 9 10 1 2
					if (i >= n)
						Console.Write(array[i] + " ");
				}

				for (int i = 0; i < array.Length; i++)
				{
					if (i < n)
						Console.Write(array[i] + " ");
				}
			}
			else
			{
				for (int i = array.Length - n; i < array.Length; i++) // Выводим последовательность с положительным смещением типа
				{														//9 10 1 2 3 4 5 6 7 8
					Console.Write(array[i] + " ");
				}

				for (int i = 0; i < array.Length - n; i++)
				{
					Console.Write(array[i] + " ");
				}
			}
		}
	}
}
