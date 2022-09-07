using System;

namespace Work_6.Task_2
{
    public class OutputData
    {
        private int _count;
        private string _done = "[x]", _noDone = "[ ]";

        private int _countFlags;
        public int CountFlags => _countFlags;

        private int _countNoFlags;
        public int CountNoFlags => _countNoFlags;

        public ToDo[] OutputToDoList(ToDo[] _array, int numberArray)
        {
            _count = 1;
            int i = 0;

            Console.Clear();
            Console.WriteLine("Список задач:\n");

            foreach (ToDo toDo in _array)
            {
                if (_count == numberArray || toDo.IsDone)
                {
                    Console.WriteLine($"{_count} {_done} {toDo.Title}");
                    _array[i].IsDone = true;
                    _countFlags++;
                }
                else
                {
                    Console.WriteLine($"{_count} {_noDone} {toDo.Title}");
                    _countNoFlags++;
                }

                _count++;
                i++;
            }

            return _array;
        }
    }
}
