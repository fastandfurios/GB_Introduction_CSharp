using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class InputData
    {
	    private string _object;
		
	    public object Input()
	    {
		    Console.Write("\nВведите PID или имя процесса, который нужно завершить: ");
		    _object = Console.ReadLine();
			
		    if (int.TryParse(_object, out int result))
			    return result;

		    return _object;
	    }
    }
}
