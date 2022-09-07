using System;

namespace Work_4
{
    public static class Task_1
    {
        public static void Run()
        {
            string[,,] people = {{{"Антон","Лев", "Иван"},
                {"Павлович","Николаевич","Сергеевич"},
                {"Чехов", "Толстой", "Тургенев"}}};

            for (int i = 0; i < people.Rank; i++)
                Console.WriteLine(GetFullName(people[0, 0, i], people[0, 2, i], people[0, 1, i]));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
            => $"{firstName} {patronymic} {lastName}";
    }
}
