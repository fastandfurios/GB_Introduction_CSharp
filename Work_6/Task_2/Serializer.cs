using System.IO;
using System.Text.Json;

namespace Work_6.Task_2
{
    public class Serializer
    {
        private string[] _jsonArray;

        public void SerilizeArrayTask(ToDo[] array, string fileName)
        {
            _jsonArray = new string[array.Length];

            for (int a = 0; a < _jsonArray.Length; a++)
                _jsonArray[a] = JsonSerializer.Serialize(array[a]);

            File.WriteAllLines(fileName, _jsonArray);
        }
    }
}
