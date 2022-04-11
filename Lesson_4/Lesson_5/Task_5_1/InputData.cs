using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_1
{
    public class InputData
    {
	    private string _text;
	    private Recording _recording = new Recording();

        public void Input()
        {
	        Console.WriteLine("Введите любой текст:");
	        _text = Console.ReadLine();
            _recording.WriteText(_text);
        }
    }
}
