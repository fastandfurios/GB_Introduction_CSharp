using System;
using ExternalLibrary;

namespace Process
{
	class Program
	{
		static void Main(string[] args)
		{
			//1 Задача
			var taskManager = new TaskManager();
			taskManager.Run();

			//2 Задача
			var quote = new Quote();
			quote.Run();
		}
	}
}
