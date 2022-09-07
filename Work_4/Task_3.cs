using System;

namespace Work_4
{
    public static class Task_3
    {
        public static void Run()
        {
            int number = 0;

            string numberMonth = string.Empty;
            Input(ref numberMonth);

            string[] arrayNumbersMonth = new string[12];
            FillArray(arrayNumbersMonth);

            if (Compare(arrayNumbersMonth, numberMonth))
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

        /// <summary>
        /// Создает массив чисел в строковом представлении
        /// </summary>
        /// <param name="arrayNumbersMonth">Пустой массив</param>
        static void FillArray(string[] arrayNumbersMonth)
        {
            for (int i = 0; i < arrayNumbersMonth.Length; i++)
                arrayNumbersMonth[i] = (i + 1).ToString();
        }

        /// <summary>
        /// Сравнивает введенный номер месяца пользователя со значениями в массиве
        /// </summary>
        /// <param name="arrayNumbersMonth">Массив строк</param>
        /// <param name="numberMonth">Номер месяца</param>
        /// <returns>Либо истина, либо ложь</returns>
        static bool Compare(string[] arrayNumbersMonth, string numberMonth)
        {
            foreach (var number in arrayNumbersMonth)
            {
                if (number.Equals(numberMonth))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Получает результат в зависимости от введенного пользователем номера месяца
        /// </summary>
        /// <param name="number">Номер месяца</param>
        static void GetSeason(int number)
        {
            if ((int)Season.Зима <= number && number < (int)Season.Весна || number == (int)Season.Декабрь)
                Console.WriteLine($"Время года: {Season.Зима}");

            if ((int)Season.Весна <= number && number < (int)Season.Лето)
                Console.WriteLine($"Время года: {Season.Весна}");

            if ((int)Season.Лето <= number && number < (int)Season.Осень)
                Console.WriteLine($"Время года: {Season.Лето}");

            if ((int)Season.Осень <= number && number < (int)Season.Декабрь)
                Console.WriteLine($"Время года: {Season.Осень}");
        }
    }

    enum Season
    {
        Зима = 1,
        Весна = 3,
        Лето = 6,
        Осень = 9,
        Декабрь = 12
    }
}
