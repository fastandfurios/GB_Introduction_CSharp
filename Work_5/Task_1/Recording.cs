using System.IO;
using System.Text;

namespace Work_5.Task_1
{
    public class Recording
    {
        private string _fileName = "text.txt";

        public void WriteText(string text)
            => File.WriteAllText(_fileName, text, Encoding.UTF8);
    }
}
