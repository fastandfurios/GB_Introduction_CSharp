using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.ToDoList
{
    public class InputData
    {
	    private int _number, _numberTask;
	    private ToDo[] _array;

	    public ToDo[] Array
	    {
		    get => _array;
	    }

	    public void Input() => InputNumberTasks();

	    private void InputNumberTasks()
	    {
		    try
		    {
			    Console.Write("Введите количество задач: ");
			    _number = Convert.ToInt32(Console.ReadLine());
			    Console.WriteLine();

			    if (_number > 0)
				    InputToDoList();
			    else
				    Console.WriteLine("Конец программы!");
			}
		    catch (Exception e)
		    {
			   Console.WriteLine(e.Message);
		    }
	    }

	    private void InputToDoList()
	    {
		    _array = new ToDo[_number];
		    try
		    {
			    for (int i = 0; i < _array.Length; i++)
			    {
				    Console.Write($"{i + 1} ");
				    _array[i] = new ToDo { Title = Console.ReadLine(), IsDone = false };
			    }
			}
		    catch (Exception e)
		    {
			    Console.WriteLine(e);
		    }
	    }

	    public int InputNumberTask()
	    {
		    Console.WriteLine();
		    Console.WriteLine("Введите номер задачи, которую хотите выполнить: ");
		    try
		    {
			    _numberTask = Convert.ToInt32(Console.ReadLine());
			    if (_numberTask > 0)
				    return _numberTask;
			    else
				    Console.WriteLine("Конец программы!");

			    return 1;
			}
		    catch (Exception e)
		    {
			    Console.WriteLine(e);
		    }

		    return 1;
	    }
    }
}
