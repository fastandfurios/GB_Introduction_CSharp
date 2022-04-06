using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5.Task_5_3
{
    public class Range
    {
	    private const int MIN = 0, MAX = 255;

		/// <summary>
		/// Проверяет, лежит ли число в диапазоне от 0 до 255
		/// </summary>
		/// <param name="number">Число, введенное пользователем</param>
		/// <returns>Возвращает либо истину, либо ложь</returns>
	    public bool IsRange(int number)
	    {
		    if (MIN <= number && number <= MAX)
			    return true;

		    return false;
	    }
    }
}
