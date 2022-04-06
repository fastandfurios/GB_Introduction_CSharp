using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.ToDoList
{
    public class Objects
    {
	    protected InputData _inputData;
	    protected Serilizer _serilizer;
	    protected Deserilizer _deserilizer;
	    protected OutputData _outputData;

		public Objects()
		{
			_inputData = new InputData();
			_serilizer = new Serilizer();
			_deserilizer = new Deserilizer();
			_outputData = new OutputData();
		}
    }
}
