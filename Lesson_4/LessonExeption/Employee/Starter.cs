using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonExeption.Employee
{
    public class Starter
    {
	    private Person[] _arrayPersons = new Person[5];

	    public void Start()
	    {
			CompleteArrayPersons();
			OutputArrayPersons();
	    }

	    private void CompleteArrayPersons()
	    {
		    _arrayPersons[0] = new Person("Михаил Васильевич Ломоносов", "Ученый", "MVL@mail.ru", 89218989696, 48000, 49);
		    _arrayPersons[1] = new Person("Александр Сергеевич Пушкин", "Поэт", "ASP@yandex.ru", 89998560000, 50000, 42);
		    _arrayPersons[2] = new Person("Илья Ефимович Репин", "Художник", "IliaR@gmail.ru", 89232229755, 45000, 39);
		    _arrayPersons[3] = new Person("Константин Сергеевич Станиславский", "Актер", "Konstatntin@rambler.ru", 89098789983, 52000, 45);
		    _arrayPersons[4] = new Person("Петр Яковлевич Чаадаев", "Философ", "Petr@mail.ru", 89205556874, 47000, 40);
		}

	    private void OutputArrayPersons()
	    {
		    foreach (Person person in _arrayPersons)
		    {
			    if(person.Age > 40)
				    Console.WriteLine(person);
		    }
	    }
    }
}
