using System;

namespace Work_6.Task_3
{
    [Serializable]
    public class MyArraySizeException : Exception
    {
        private string _message;

        public MyArraySizeException(string message) : base(message) => _message = message;

        public override string ToString()
            => _message;
    }
}
