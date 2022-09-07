using System;

namespace Work_5.Task_3
{
    public class OutputData
    {
        private BinReader _binReader = new BinReader();

        /// <summary>
        /// Выводит массив байт в консоль
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void Output(string fileName)
        {
            byte[] array = _binReader.GetBytes(fileName);

            foreach (var number in array)
                Console.Write(number + " ");
        }
    }
}
