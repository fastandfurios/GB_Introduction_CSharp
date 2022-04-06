using System;

namespace Task_3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// 2 задача

			string[,] array = {{ "\"Сбербанк\"", "Банк \"ВТБ\"", "ПАО \"Банк СГБ\"", "Tinkoff" },
								{ "+7(495)500-55-50", "+7(495)777-24-24", "8-800-100-55-22", "+7(495)645-59-19" }};

			for (int i = 0; i < array.GetLength(1); i++)
			{
				Console.WriteLine($"{array[0,i]} {array[1,i], 20}");
			}
		}
	}
}
