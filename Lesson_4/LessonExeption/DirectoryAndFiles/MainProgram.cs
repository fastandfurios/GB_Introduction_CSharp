﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.DirectoryAndFiles
{
    public class MainProgram
    {
	    private string _workDir = @"C:\WorkDocuments";
	    private int _i, _count;
	    private string _fileName = "resultRecursion.txt";

	    public void Start()
		{
			GetDirectoryAndFiles();
			GetDirectoryRecursion();
			GetFilesRecursion();
		}
		

		/// <summary>
		/// Получает список всех директорий и файлов из заданной директории и сохраняет их в текстовый файл
		/// </summary>
		private void GetDirectoryAndFiles()
		{
			string[] entries = Directory.GetFileSystemEntries(_workDir, "*", SearchOption.AllDirectories);
			File.WriteAllLines("result.txt", entries);
		}

		private void GetDirectoryRecursion()
		{
			if(_workDir != null && _i < Directory.GetDirectories(_workDir).Length)
			{
					File.AppendAllText(_fileName, Directory.GetDirectories(_workDir)[_i]);
					File.AppendAllText(_fileName, Environment.NewLine);
					_i++;
			}
			else
				return;
			
			GetDirectoryRecursion();
		}

		private void GetFilesRecursion()
		{
			if (_workDir != null && _count < Directory.GetFiles(_workDir).Length)
			{
				File.AppendAllText(_fileName, Directory.GetFiles(_workDir)[_count]);
				File.AppendAllText(_fileName, Environment.NewLine);
				_count++;
			}
			else
				return;

			GetFilesRecursion();
		}
	}
}
