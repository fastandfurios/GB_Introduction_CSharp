using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class InputData
    {
	    private string _emptyNumbers;
	    private Converter _converter = new Converter();
	    private BinWriter _binWriter = new BinWriter();

		/// <summary>
		/// Дает ввести не пустую строку пользователю, если строка пустая, повторяет действие
		/// </summary>
		/// <param name="fileName">Принимает параметр (имя файла), куда будем сохранять введенную строку</param>
		public void Input(string fileName)
        {
			do
			{
				Console.Clear();
				Console.WriteLine("Введите последовательность чисел в произвольном порядке от 0 до 255 через пробел: ");
				_emptyNumbers = Console.ReadLine();
			} while (_emptyNumbers == string.Empty);

			byte[] array = _converter.Convert(_emptyNumbers);

			_binWriter.WriteBin(array, fileName);
        }
    }
}
