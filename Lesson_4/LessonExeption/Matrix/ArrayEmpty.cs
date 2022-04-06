using System;

namespace LessonExeption.Matrix
{
    public class ArrayEmpty
    {
	    private string _messageLength = "Размер массива не соответсвует эталонному! Программа завершилась с ошибкой!";
	    private string _messageData = "В массиве неверный формат данных, расположенный по индексу ";

		private string[,] _array = {{"1","2","5","4"}, {"3","6","O","7"}, {"6","8","4","3"}, {"6","12","3","6"}};
        private int[,] _arrayNumbers;
        private int _indexI, _indexJ;

		public void Run()
		{
			try
			{
				CheckLengthArray();
				Console.WriteLine("Сумма всех элементов в массиве составит: {0}", GetSum());
			}
			catch (MyArraySizeException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (MyArrayDataException e)
			{
				Console.WriteLine(e.Message);
			}
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
	        _arrayNumbers = new int[4, 4];

	        try
	        {
		        for (int i = 0; i < _array.GetLength(0); i++)
		        {
			        _indexI = i;
			        for (int j = 0; j < _array.GetLength(1); j++)
			        {
				        _indexJ = j;
				        _arrayNumbers[i, j] = Convert.ToInt32(_array[i, j]);
					}
		        }
			}
	        catch
	        {
		        throw new MyArrayDataException(_messageData + $"[{_indexI}, {_indexJ}]! Программа завершилась с ошибкой!");
	        }
        }

        private int GetSum()
        {
	        int sum = 0;

	        foreach (var number in _arrayNumbers)
		        sum += number;

	        return sum;
        }
    }
}
