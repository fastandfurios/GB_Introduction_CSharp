using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class BinReader
    {
	    public byte[] GetBytes(string fileName)
		    => File.ReadAllBytes(fileName);
    }
}
