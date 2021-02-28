using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_2
{
    public class CreaterFile
    {
		private string _fileName;

		public string FileName
		{
			get => _fileName;
			set
			{
				_fileName = value;
				WriteCurrentTime();
			} 
		}

		private void WriteCurrentTime()
		{
			File.WriteAllText(_fileName, DateTime.Now.ToString());
			File.AppendAllText(_fileName, Environment.NewLine);
		}
	}
}
