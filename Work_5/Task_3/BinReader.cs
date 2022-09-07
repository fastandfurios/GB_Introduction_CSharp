using System.IO;

namespace Work_5.Task_3
{
    public class BinReader
    {
        /// <summary>
        /// Считывает файл и возвращает массив байт
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Массив байт</returns>
        public byte[] GetBytes(string fileName)
            => File.ReadAllBytes(fileName);
    }
}
