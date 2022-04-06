using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LessonExeption.ToDoList
{
    public class Serilizer
    {
	    private string[] _jsonArray;
 
	    public void SerilizeArrayTask(ToDo[] array, string fileName)
	    {
		    _jsonArray = new string[array.Length];

		    for (int a = 0; a < _jsonArray.Length; a++)
			    _jsonArray[a] = JsonSerializer.Serialize(array[a]);

			File.WriteAllLines(fileName, _jsonArray);
	    }
    }
}
