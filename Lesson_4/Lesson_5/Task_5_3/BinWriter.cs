using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class BinWriter
    {
	    private string fileName = "bytes.bin";

	    public void WriteBin(byte[] array)
			=> File.WriteAllBytes(fileName, array);
    }
}
