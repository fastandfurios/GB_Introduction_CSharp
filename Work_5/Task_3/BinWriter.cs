using System.IO;

namespace Work_5.Task_3
{
    public class BinWriter
    {
        /// <summary>
        /// Записывает массив байт в файл .bin
        /// </summary>
        /// <param name="array">Массив байт</param>
        /// <param name="fileName">Имя файла</param>
        public void WriteBin(byte[] array, string fileName)
            => File.WriteAllBytes(fileName, array);
    }
}
