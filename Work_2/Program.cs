using System;

namespace Work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задача

            int minTemperature;
            int maxTemperature;
            int mediumTemperature;
            const int number = 2;

            Console.Write("Введите минимальную температуру за сутки: ");
            minTemperature = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки: ");
            maxTemperature = Convert.ToInt32(Console.ReadLine());

            mediumTemperature = (minTemperature + maxTemperature) / number;

            Console.WriteLine($"Среднесуточная температура составит: {mediumTemperature}");
            Console.ReadKey();
            Console.Clear();
            //-----------------------------------------------------------------------------

            //2 задача

            int numberMonth;

            Console.Write("Введите номер текущего месяца: ");
            numberMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Текущий месяц: {(Months)numberMonth}");

            Console.ReadKey();
            Console.Clear();
            //-----------------------------------------------------------------------------

            //3 задача

            int num;

            Console.Write("Введите любое число: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} — является четным числом!");
            else
                Console.WriteLine($"{num} — является нечетным числом!");

            Console.ReadKey();
            Console.Clear();
            //-----------------------------------------------------------------------------

            //4 задача

            int id = 4059743;
            decimal price = 39.99m;
            decimal priceSale = 39.99m;
            string name = "Сок яблочный";
            double volume = 1;
            char sym = '%';
            DateTime dateTime = new DateTime(2021, 02, 14, 11, 28, 52);

            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Кассовый чек");
            Console.WriteLine($"Дата: {dateTime}");
            Console.WriteLine("\tЦена\tСкидка\tЦена со скидкой\tКоличество\tИтого");
            Console.WriteLine($"{id}\t\t\t{name}");
            Console.WriteLine($"\t{price}\t\t\t{priceSale}\t*\t{volume}\t{priceSale * (decimal)volume}");
            Console.WriteLine($"НДС 10{sym}");

            id = 3953590;
            price = 29.19m;
            priceSale = 29.19m;
            volume = 2.020;
            name = "Картофель";

            Console.WriteLine($"{id}\t\t\t{name}");
            Console.WriteLine($"\t{price}\t\t\t{priceSale}\t*\t{volume}\t{Math.Round(priceSale * (decimal)volume, 2)}");
            Console.WriteLine($"НДС 10{sym}");

            id = 197;
            price = 29.99m;
            priceSale = 29.99m;
            volume = 0.165;
            name = "Лук репчатый";

            Console.WriteLine($"{id}\t\t\t{name}");
            Console.WriteLine($"\t{price}\t\t\t{priceSale}\t*\t{volume}\t{Math.Round(priceSale * (decimal)volume, 2)}");
            Console.WriteLine($"НДС 10{sym}");
            Console.ReadKey();
            Console.Clear();
            //-----------------------------------------------------------------------------

            //5 задача: данные берутся из задачи 1 и 2

            if (numberMonth == 12 || numberMonth == 1 || numberMonth == 2 || mediumTemperature > 0)
            {
                Console.WriteLine("Дождливая зима");
            }

            Console.ReadKey();
            Console.Clear();
            //-----------------------------------------------------------------------------

            //6 задача

            Week office_1 = Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница;
            Week office_2 = Week.Понедельник | Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница | Week.Суббота | Week.Воскресенье;

            Console.WriteLine($"Офис №1 работает: {office_1}");
            Console.WriteLine($"Офис №2 работает: {office_2}");

            Console.ReadKey();
            Console.Clear();
            //-----------------------------------------------------------------------------

            // Дополнительная задача

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 != 0 || year % 100 == 0 && year % 400 != 0)
            {
                Console.WriteLine("Не високосный");
            }
            else
            {
                Console.WriteLine("Високосный");
            }

            Console.ReadKey();
        }
    }

    enum Months
    {
        Январь = 1,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }

    [Flags]
    enum Week
    {
        Понедельник = 0b_0000_0001,
        Вторник = 0b_0000_0010,
        Среда = 0b_0000_0100,
        Четверг = 0b_0000_1000,
        Пятница = 0b_0001_0000,
        Суббота = 0b_0010_0000,
        Воскресенье = 0b_0100_0000
    }
}
