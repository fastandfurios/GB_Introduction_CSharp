using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonExeption.ToDoList
{
    public class StarterProgram 
    {
	    private string _fileName = "tasks.json";
	    private InputData _inputData = new InputData();
	    private ToDo[] _array;
	    private Serilizer _serilizer = new Serilizer();
	    private Deserilizer _deserilizer = new Deserilizer();
	    private OutputData _outputData = new OutputData();
	    private int _numberTask;

	    public void Start() => Run();

	    private void Run()
	    {
		    if (File.Exists(_fileName))
		    {
				_deserilizer.DeserilizArrayTask(_fileName);
				_array = _outputData.OutputArrayNoFlags(_deserilizer.ArrayTasks);

				if (_outputData.CountFlags == _array.Length)
				{
					Console.WriteLine("\nВсе задачи выполнены! Список очистится автоматически!");
					Thread.Sleep(5000);
					Console.Clear();
					Execute();
					Run();
				}
				else
				{
					_numberTask = _inputData.InputNumberTask();
					_array = _outputData.OutputArrayFlags(_numberTask);
					_serilizer.SerilizeArrayTask(_array, _fileName);
				}
		    }
		    else
		    {
				Execute();
				Console.ReadLine();
				Console.Clear();
				Run();
		    }
	    }

	    private void Execute()
	    {
		    _inputData.Input();
		    _array = _inputData.Array;
		    _serilizer.SerilizeArrayTask(_array, _fileName);
		    Console.WriteLine("Файл со списком задач успешно сохранен!");
		}
    }
}
