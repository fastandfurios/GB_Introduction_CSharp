using System;

namespace Task_4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// 2 Задача

			string numbersEntry = string.Empty;
			Input(ref numbersEntry);

			int[] arrayNumbers = Convert(numbersEntry);

			int sum;
			GetSum(arrayNumbers, out sum);

			Output(sum);

			Console.ReadLine();
		}

		/// <summary>
		/// Вводит последовательность
		/// </summary>
		/// <param name="str">Строка, которую вводит пользователь</param>
		static void Input(ref string str)
		{
			Console.WriteLine("Введите последовательность чисел через пробел:");
			str = Console.ReadLine();
		} 

		/// <summary>
		/// Конвертирует строку в массив чисел
		/// </summary>
		/// <param name="str">Строка, введенная пользователем</param>
		/// <returns>Массив чисел</returns>
		static int[] Convert(string str)
		{
			int count = 0;
			int[] arrayNumbers = new int[str.Split(" ").Length];

			foreach (string number in str.Split(" "))
			{
				if (int.TryParse(number, out int result))
					arrayNumbers[count] = result;

				count++;
			}

			return arrayNumbers;
		}

		/// <summary>
		/// Складывает все числа в последовательности
		/// </summary>
		/// <param name="arrayNumbers">Массив чисел</param>
		/// <param name="sum">Собственно, сама сумма</param>
		static void GetSum(int[] arrayNumbers, out int sum)
		{
			sum = 0;

			for (int i = 0; i < arrayNumbers.Length; i++)
				sum += arrayNumbers[i];
		}

		/// <summary>
		/// Выводит сумму на экран
		/// </summary>
		/// <param name="result">Сумма чисел</param>
		static void Output(int result)
			=> Console.WriteLine($"Сумма всех чисел последовательности составит: {result}");
	}
}
