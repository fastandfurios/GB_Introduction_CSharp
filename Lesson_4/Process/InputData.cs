using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    public class InputData
    {
	    private string _name;


	    public object Input()
	    {
		    Console.Write("Введите PID или имя процесса, который нужно завершить: ");
		    _name = Console.ReadLine();
			
		    if (int.TryParse(_name, out int result))
		    {
			    return result;
		    }

		    return _name;
	    }
    }
}
