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

        public void Input()
        {
			do
			{
				Console.Clear();
				Console.WriteLine("Введите последовательность чисел в произвольном порядке от 0 до 255 через пробел: ");
				_emptyNumbers = Console.ReadLine();
			} while (_emptyNumbers == string.Empty);

			_converter.Convert(_emptyNumbers);
        }
    }
}
