using System;

namespace Lab_rab_KalyamovaE.A._BPI_24_01_Part1
{ 
    public class Worker
    {
        //поля
        private string _surname;
        private double _salary;
        private DateTime _birthDate;

        //фамилия
        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("фамилия не может быть пустой!!");
                _surname = value.Trim();
            }
        }

        //оклад
        public double Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("оклад не может быть отрицательным!!");
                _salary = value;
            }
        }

        //дата рождения
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException("дата рождения не может быть в будущем!!");
                _birthDate = value;
            }
        }

        //конструкторы
        public Worker() : this("Неизвестно", 0, DateTime.Today) { }

        public Worker(string surname, double salary, DateTime birthDate)
        {
            Surname = surname;
            Salary = salary;
            BirthDate = birthDate;
        }

        //метод возраста работника
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - _birthDate.Year;

            if (_birthDate.Date > today.AddYears(-age))
                age--;

            return age;
        }

        //метод дней до 50 лет
        public int DaysUntil50()
        {
            DateTime date50 = _birthDate.AddYears(50);

            if (date50 <= DateTime.Today)
                return 0;

            return (date50 - DateTime.Today).Days;
        }

        //вывод
        public override string ToString() =>
            $"Работник: {_surname}, оклад {_salary:F2}, дата рождения {_birthDate:dd.MM.yyyy}";
    }
}
