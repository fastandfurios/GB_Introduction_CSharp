using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.Matrix
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
