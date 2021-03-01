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
        /// <summary>
        /// Записывает массив байт в файл .bin
        /// </summary>
        /// <param name="array">Массив байт</param>
        /// <param name="fileName">Имя файла</param>
	    public void WriteBin(byte[] array,string fileName)
			=> File.WriteAllBytes(fileName, array);
    }
}
