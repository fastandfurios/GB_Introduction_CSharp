using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.Matrix
{
    public class ArrayEmpty
    {
	    private string _messageLength = "Размер массива не соответсвует эталонному! Программа завершилась с ошибкой!";
	    private string _messageData = "В массиве неверный формат данных! Программа завершилась с ошибкой!";

		private string[,] _array = {{"1","2","i","4"}, {"3","6","8","7"}, {"6","8","4","3"}, {"6","6","3","6"}};
        private int[] _arrayNumbers;
        private int _count;

		public void Run()
		{
			try
			{
				CheckLengthArray();
			}
			catch (MyArraySizeException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (MyArrayDataException e)
			{
				Console.WriteLine(e.Message);
			}

			Console.WriteLine("Сумма всех элементов в массиве составит: {0}", GetSum());
		}

        private void CheckLengthArray()
		{
			if (_array.Length == 16)
				ConvertEntryInNumbers();
			else
				throw new MyArraySizeException(_messageLength);
		}

        private void ConvertEntryInNumbers()
        {
	        _arrayNumbers = new int[_array.Length];

	        try
	        {
		        foreach (string entry in _array)
		        {
			        _arrayNumbers[_count] = Convert.ToInt32(entry);
			        _count++;
		        }
			}
	        catch
	        {
		        throw new MyArrayDataException(_messageData);
	        }
        }

        private int GetSum() => _arrayNumbers.Sum();
    }
}
