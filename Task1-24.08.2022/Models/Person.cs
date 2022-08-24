using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_24._08._2022.Models
{
    abstract class Person
    {
        private static int _id;
        private int _age;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get { return _age; } set { if (value > 0) _age = value; } }

        public Person(string Name, string Surname, int Age)
        {
            _id++;
            Id = _id;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public abstract void ShowInfo();
    }
}
