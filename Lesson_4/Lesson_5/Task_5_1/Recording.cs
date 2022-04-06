using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_1
{
    public class Recording
    {
	    private string _fileName = "text.txt";

	    public void WriteText(string text)
			=> File.WriteAllText(_fileName, text, Encoding.UTF8);
    }
}
