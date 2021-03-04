﻿using System;
using LessonExeption.DirectoryAndFiles;
using LessonExeption.Employee;
using LessonExeption.ToDoList;

namespace LessonExeption
{
	class Program
	{
		static void Main(string[] args)
		{

			//1 задача
			MainProgram program = new MainProgram();
			program.Start();

			//2 задача
			StarterProgram starterProgram = new StarterProgram();
			starterProgram.Start();

			//4 задача
			Starter starter = new Starter();
			starter.Start();
		}
	}
}
