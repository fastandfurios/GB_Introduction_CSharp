using System;
using DiagProcess = System.Diagnostics.Process;

namespace Work_8.Task_1
{
    public class TaskManager
    {
        private string _entryImageName = new string('=', 25);
        private string _entryPID = new string('=', 8);
        private DiagProcess[] _array = DiagProcess.GetProcesses();
        private InputData _input = new InputData();

        public void Run()
        {
            Console.Title = nameof(TaskManager);
            DrawHead();
            PrintList();
            RemoveProcess();
        }

        private void DrawHead()
            => Console.Write($"Image Name {"PID",23}\n{_entryImageName} {_entryPID}\n");

        private void PrintList()
        {
            foreach (DiagProcess process in _array)
            {
                if (process.ProcessName.Length >= _entryImageName.Length)
                {
                    foreach (var sym in process.ProcessName.ToCharArray(0, 22))
                        Console.Write(sym);

                    PrintList("...", process, 0, 0);
                }
                else
                    PrintList(process.ProcessName, process, _entryImageName.Length, process.ProcessName.Length);
            }
        }

        private void PrintList(string str, DiagProcess process, int number, int length)
        {
            Console.Write($"{str}" +
                          $"{new string(' ', number + _entryPID.Length + 1 - length - process.Id.ToString().Length)}" +
                          $"{process.Id}");
            Console.WriteLine();
        }

        private void RemoveProcess()
        {
            int pid = 0;
            string name = string.Empty;
            object obj = _input.Input();

            if (obj is int)
                pid = (int)obj;

            if (obj is string)
                name = (string)obj;

            foreach (var process in _array)
            {
                if (pid != 0)
                    if (process.Id == pid)
                    {
                        name = process.ProcessName;
                        process.WaitForExit(100);
                    }


                if (name != string.Empty)
                    if (name.Equals(process.ProcessName))
                    {
                        pid = process.Id;
                        process.WaitForExit(100);
                    }
            }

            Console.WriteLine($"Процесс {name} {pid} завершен!");
        }
    }
}
