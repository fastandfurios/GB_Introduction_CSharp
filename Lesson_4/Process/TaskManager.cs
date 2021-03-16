using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagProcess = System.Diagnostics.Process;

namespace Process
{
    public class TaskManager
    {
	    private string _entryImageName = new string('=', 25);
	    private string _entryPID = new string('=', 8);
	    private string _entryMemUsage = new string('=', 16);
	    private DiagProcess[] _array = DiagProcess.GetProcesses();
	    private InputData _input = new InputData();

	    public void Run() => DrawHead();

	    private void DrawHead()
	    {
		    Console.Write($"Image Name");
		    Console.Write($"{"PID",24} ");
		    Console.Write($"{"Mem Usage", 16}");
		    Console.WriteLine();
		    Console.WriteLine($"{_entryImageName} {_entryPID} {_entryMemUsage}");

			PrintList();
		}

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
		                  $"{process.Id}" +
		                  $"{new string(' ', 1 + _entryMemUsage.Length - process.VirtualMemorySize64.ToString().Length)}" +
		                  $"{process.VirtualMemorySize64}");
		    Console.WriteLine();
		}

	    private void RemoveProcessByNumber()
	    {
		    int pid = (int)_input.Input();

		    foreach (var process in _array)
		    {
			    if (pid == process.Id)
			    {

			    }
		    }
	    }
	}
}
