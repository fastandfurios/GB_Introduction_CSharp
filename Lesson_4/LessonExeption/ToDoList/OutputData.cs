﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.ToDoList
{
    public class OutputData
    {
	    private int _count = 1;
	    private string _done = "[x]";
	    private ToDo[] _array;

	    private int _countFlags;
	    public int CountFlags
	    {
		    get => _countFlags;
	    }
		
	    public ToDo[] OutputArrayNoFlags(ToDo[] array)
	    {
		    _array = array;

		    Console.WriteLine("Список задач:\n");
		    foreach (ToDo toDo in array)
		    {
			    if (toDo.IsDone)
			    {
				    Console.WriteLine($"{_count} {_done} {toDo.Title}");
				    _countFlags++;
			    }
				else
					Console.WriteLine($"{_count} {toDo.Title}");

				_count++;
		    }

		    return _array;
	    }

	    public ToDo[] OutputArrayFlags(int numberArray)
	    {
		    _count = 1;
		    int i = 0;

			Console.Clear();
			Console.WriteLine("Список задач:\n");

			foreach (ToDo toDo in _array)
			{
				if (_count == numberArray)
				{
					Console.WriteLine($"{_count} {_done} {toDo.Title}");
					_array[i].IsDone = true;
					_countFlags++;
				}
				else if (toDo.IsDone)
					Console.WriteLine($"{_count} {_done} {toDo.Title}");
				else
					Console.WriteLine($"{_count} {toDo.Title}");
					
				_count++;
				i++;
			}

			return _array;
	    }
    }
}