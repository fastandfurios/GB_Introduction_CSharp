using System;

namespace Work_3
{
    public static class Task_1
    {
        public static void Run()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
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
