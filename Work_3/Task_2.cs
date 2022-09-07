using System;

namespace Work_3
{
    public static class Task_2
    {
        public static void Run()
        {
            string[,] array = {{ "\"Сбербанк\"", "Банк \"ВТБ\"", "ПАО \"Банк СГБ\"", "Tinkoff" },
                { "+7(495)500-55-50", "+7(495)777-24-24", "8-800-100-55-22", "+7(495)645-59-19" }};

            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine($"{array[0, i]} {array[1, i],20}");
            }
        }
    }
}
