using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LessonExeption.ToDoList
{
    public class Deserilizer
    {
	    private ToDo[] _array;
	    public ToDo[] ArrayTasks
	    {
		    get => _array;
	    }

	    public void DeserilizArrayTask(string fileName)
	    {
		    int i = 0;
		    int length = File.ReadAllText(fileName).Split("\r\n").Length - 1;

			_array = new ToDo[length];

			foreach (string json in File.ReadAllText(fileName).Split("\r\n"))
		    {
			    if (i < length)
				    _array[i] = JsonSerializer.Deserialize<ToDo>(json);

			    i++;
		    }
	    }
    }
}
