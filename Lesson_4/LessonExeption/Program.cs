using System;
using LessonExeption.DirectoryAndFiles;
using LessonExeption.Employee;

namespace LessonExeption
{
	class Program
	{
		static void Main(string[] args)
		{
			MainProgram program = new MainProgram();
			program.Start();

			Starter starter = new Starter();
			starter.Start();
		}
	}
}
