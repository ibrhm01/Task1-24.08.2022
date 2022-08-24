using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_24._08._2022.Models
{
    class Teacher : Person
    {
        private float _salary;
        public float Salary { get { return _salary; } set { if (value > 0) _salary = value; } }
        public Teacher(string Name, string Surname,int Age, float Salary):base(Name, Surname, Age)
        {
            this.Salary = Salary;
        }
        public static bool operator <(Teacher Teacher1, Teacher Teacher2)
        {
            return Teacher1.Salary < Teacher2.Salary;
        }
        public static bool operator >(Teacher Teacher1, Teacher Teacher2)
        {
            return Teacher1.Salary > Teacher2.Salary;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nId:{Id}\nSalary: {Salary}\n");
        }
    }
}
