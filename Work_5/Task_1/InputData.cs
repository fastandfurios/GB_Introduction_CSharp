using System;

namespace Work_5.Task_1
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
