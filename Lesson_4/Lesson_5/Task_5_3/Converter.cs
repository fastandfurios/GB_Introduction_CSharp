using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class Converter
    {
	    private Range _range = new Range();
	    private BinWriter _binWriter = new BinWriter();
	    private int _count;

	    public void Convert(string emptyNumbers)
	    {
		    string newEmptyNumbers = GetNewEmptyNumbers(emptyNumbers);
		    byte[] array = new byte[newEmptyNumbers.Split(" ").Length];

		    foreach (string number in newEmptyNumbers.Split(" "))
		    {
			    if (byte.TryParse(number, out byte result))
				    if (_range.IsRange(result))
					    array[_count] = result;

			    _count++;
		    }

		    _binWriter.WriteBin(array);
	    }


	    private string GetNewEmptyNumbers(string emptyNumbers)
	    {
		    foreach (var number in emptyNumbers.Split(" "))
		    {
			    if (number == string.Empty) { }
			    else
				    return number + " " + number;
		    }

		    return "1";
	    }
    }
}
