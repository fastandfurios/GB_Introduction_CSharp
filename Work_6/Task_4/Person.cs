namespace Work_6.Task_4
{
    public class Person
    {
        private string _name,
            _post,
            _email;

        private decimal _pay;

        private long _phone;

        private short _age;
        public short Age
        {
            get => _age;
        }

        public Person(string name, string post, string email, long phone, decimal pay, short age)
        {
            _name = name;
            _post = post;
            _email = email;
            _phone = phone;
            _pay = pay;
            _age = age;
        }

        public override string ToString()
            => $"{_name}, {_post}, {_email}, {_phone}, {_pay}, {_age}";
    }
}
