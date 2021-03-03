using System;
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

	    private string _logsDir,
					   _reportsDir,
					   _reportPath,
					   _logPath,
					   _contentLogs = "Событие",
					   _logFileName = "Log",
					   _contentReport = "Отчет",
					   _reportFileName = "Report";

	    private int _count;

	    public void Start()
		{
			SaveFilesLoop();
			SaveFilesRecursion();
		}

		/// <summary>
		/// Заполняет файлами директорию при помощи цикла for(...){...}, обратившись сначало к методу CreateDirectory()
		/// </summary>
		private void SaveFilesLoop()
        {
			CreateDirectory(ref _logsDir, "Logs");

			for (int i = 0; i < 5; i++)
			{
				_logPath = Path.Combine(_logsDir, $"{_logFileName} {i+1}.txt");
				File.WriteAllText(_logPath, $"{_contentLogs} {i+1}");
			}
        }

		/// <summary>
		/// Заполняет файлами директорию при помощи рекурсии, обратившись сначало к методу CreateDirectory()
		/// </summary>
		private void SaveFilesRecursion()
        {
	        if (_count == 0)
	        {
		        CreateDirectory(ref _reportsDir, "Reports");
		        _count++;
				SaveFilesRecursion();
	        }
			else
			{
				if (_count <= 5)
				{
					_reportPath = Path.Combine(_reportsDir, $"{_reportFileName} {_count}.txt");
					File.WriteAllText(_reportPath, $"{_contentReport} {_count}");
					_count++;
					SaveFilesRecursion();
				}
			}
        }

		/// <summary>
		/// Проверяет существование директорий, и если нет, то создает ее
		/// </summary>
		/// <param name="dir">Изменяемый путь вложенной директории</param>
		/// <param name="nameDir">Имя вложенной директории</param>
        private void CreateDirectory(ref string dir, string nameDir)
        {
	        if (Directory.Exists(dir))
		        Console.WriteLine("Папка с таким именем уже существует!");
	        else
	        {
		        dir = Path.Combine(_workDir, nameDir);
		        Directory.CreateDirectory(dir);
	        }
        }
	}
}
