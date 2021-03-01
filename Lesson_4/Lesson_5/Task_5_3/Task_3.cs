using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class Task_3
    {
	    private string _fileName = "bytes.bin";

	    public Task_3()
	    {
		    InputData input = new InputData();
			input.Input(_fileName);
			OutputData output = new OutputData();
			output.Output(_fileName);
	    }
    }
}
