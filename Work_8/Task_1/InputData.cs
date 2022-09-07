using System;

namespace Work_8.Task_1
{
    public class InputData
    {
        public object Input()
        {
            Console.Write("\nВведите PID или имя процесса, который нужно завершить: ");
            var name = Console.ReadLine();

            if (int.TryParse(name, out int result))
                return result;

            return name;
        }
    }
}
