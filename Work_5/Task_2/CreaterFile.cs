using System;
using System.IO;

namespace Work_5.Task_2
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
            => File.AppendAllLines(_fileName, new[] { $"Текущее время: {DateTime.Now.ToString("T")}" });
    }
}
