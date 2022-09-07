using System.IO;
using System.Text.Json;

namespace Work_6.Task_2
{
    public class Deserializer
    {
        private ToDo[] _array;
        public ToDo[] ArrayTasks
        {
            get => _array;
        }

        public void DeserilizArrayTask(string fileName)
        {
            int i = 0;
            int length = File.ReadAllText(fileName).Split("\r\n").Length - 1;

            _array = new ToDo[length];

            foreach (string json in File.ReadAllText(fileName).Split("\r\n"))
            {
                if (i < length)
                    _array[i] = JsonSerializer.Deserialize<ToDo>(json);

                i++;
            }
        }
    }
}
