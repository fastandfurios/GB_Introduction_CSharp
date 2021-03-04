using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.Matrix
{
    public class InputMatrix
    {
	    private string column;

	    public void Input()
	    {
		    Console.WriteLine("Введите матрицу размером 4x4:");
		    while (true)
		    {
			    column = Console.ReadLine();
			    Console.SetCursorPosition(column.Length + 1, 1);
		    }
	    }
    }
}
