using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class Range
    {
	    private const int MIN = 0, MAX = 255;

	    public bool IsRange(int number)
	    {
		    if (MIN <= number && number <= MAX)
			    return true;

		    return false;
	    }
    }
}
