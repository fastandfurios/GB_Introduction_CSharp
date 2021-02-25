using System;

namespace Task_4_3
{
	class Program
	{
		static void Main(string[] args)
		{
			//3 Задача

			int number = 0;
			
			string numberMonth = string.Empty;
			Input(ref numberMonth);

			string[] arrayNumbersMonth = new string[12];
			FillArray(arrayNumbersMonth);

			if(Compare(arrayNumbersMonth, numberMonth))
			{
				if (int.TryParse(numberMonth, out int result))
					number = result;
			}
			else
			{
				Console.WriteLine("Ошибка: введите число от 1 до 12");
			}

			GetSeason(number);
		}

		static void Input(ref string numberMonth)
		{
			Console.WriteLine("Введите номер месяца: ");
			numberMonth = Console.ReadLine();
		}

		static void FillArray(string[] arrayNumbersMonth)
		{
			for (int i = 0; i < arrayNumbersMonth.Length; i++)
				arrayNumbersMonth[i] = (i + 1).ToString();
		}

		static bool Compare(string[] arrayNumbersMonth, string numberMonth)
		{
			foreach (var number in arrayNumbersMonth)
			{
				if (number.Equals(numberMonth))
					return true;
			}

			return false;
		}

		static void GetSeason(int number)
		{
			if((int)Season.Зима <= number && number < (int)Season.Весна || number == 12)
				Console.WriteLine($"Время года: {Season.Зима}");
			
			if((int)Season.Весна <= number && number < (int)Season.Лето)
				Console.WriteLine($"Время года: {Season.Весна}");

			if((int)Season.Лето <= number && number < (int)Season.Осень)
				Console.WriteLine($"Время года: {Season.Лето}");

			if((int)Season.Осень <= number && number < 12)
				Console.WriteLine($"Время года: {Season.Осень}");
		}
	}

	enum Season
	{
		Зима = 1,
		Весна = 3,
		Лето = 6,
		Осень = 9
	}
}
