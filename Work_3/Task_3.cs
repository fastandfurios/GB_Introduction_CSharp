using System;

namespace Work_3
{
    public static class Task_3
    {
        public static void Run()
        {
            string str;

            do
            {
                Console.Clear();
                Console.Write("Введите \"Hello\": ");
                str = Console.ReadLine();
                str = str.ToLower();

            } while (str != "hello");

            for (int i = str.Length - 1; i >= 0; i--)
            {

                if (str[i] == 'h')
                    Console.Write(str[i].ToString().ToUpper());
                else
                    Console.Write(str[i]);
            }
        }
    }
}
