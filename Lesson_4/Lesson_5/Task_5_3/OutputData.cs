using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
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
