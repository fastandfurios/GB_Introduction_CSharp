using System;

namespace Work_5.Task_3
{
    public class Converter
    {
        private Range _range = new Range();
        private int _count;

        /// <summary>
        /// Конвертирует строку в массив байт
        /// </summary>
        /// <param name="emptyNumbers">Строка, введеная пользователем</param>
        /// <returns>Возвращает результат в виде массива байт</returns>
        public byte[] Convert(string emptyNumbers)
        {
            GetNewEmptyNumbers(ref emptyNumbers);

            byte[] array = new byte[emptyNumbers.Split(" ").Length];

            foreach (string number in emptyNumbers.Split(" "))
            {
                if (byte.TryParse(number, out byte result))
                    if (_range.IsRange(result))
                        array[_count] = result;

                _count++;
            }

            return array;
        }

        /// <summary>
        /// Проверяет и удаляет лишние пустоты в строке, если есть таковые
        /// </summary>
        /// <param name="emptyNumbers">Строка меняется так, чтобы она состояла только из одних чисел, без лишних пустот</param>
        private void GetNewEmptyNumbers(ref string emptyNumbers)
        {
            string newEmptyNumbers = null;

            foreach (var number in emptyNumbers.Split(" "))
            {
                if (number == string.Empty) { }
                else
                    newEmptyNumbers = newEmptyNumbers + " " + number;
            }

            emptyNumbers = newEmptyNumbers.TrimStart();
        }
    }
}
