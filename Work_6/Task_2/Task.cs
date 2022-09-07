using System.Threading;
using System;
using System.IO;

namespace Work_6.Task_2
{
    public class Task : Objects
    {
        private string _fileName = "tasks.json";
        private ToDo[] _array;
        private int _numberTask;

        public void Start() => Run();

        /// <summary>
        /// Запускает и управляет всей программой
        /// </summary>
        private void Run()
        {
            if (File.Exists(_fileName) && File.ReadAllText(_fileName).Length != 0)
            {
                _deserilizer.DeserilizArrayTask(_fileName);
                _array = _outputData.OutputToDoList(_deserilizer.ArrayTasks, 0);

                if (_outputData.CountFlags >= _outputData.CountNoFlags)
                {
                    Console.WriteLine("\nВсе задачи выполнены! Список очистится автоматически!");
                    Thread.Sleep(5000);
                    Console.Clear();
                    CreateAndSafeToDoList();
                    Run();
                }
                else
                {
                    _numberTask = _inputData.InputNumberTask();
                    _array = _outputData.OutputToDoList(_array, _numberTask);
                    _serilizer.SerilizeArrayTask(_array, _fileName);
                    Run();
                }
            }
            else
            {
                CreateAndSafeToDoList();
            }
        }

        /// <summary>
        /// Создает список задач и сохраняет его в файл формата .json
        /// </summary>
        private void CreateAndSafeToDoList()
        {
            _inputData.Input();
            _array = _inputData.Array;
            _serilizer.SerilizeArrayTask(_array, _fileName);
            Console.WriteLine("Файл со списком задач успешно сохранен!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
