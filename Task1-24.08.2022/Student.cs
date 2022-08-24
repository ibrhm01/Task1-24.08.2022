using System;
using System.Collections.Generic;
using System.Text;
using Task1_24._08._2022.Models;

namespace Task1_24._08._2022
{
    class Student : Person
    {
        public float Point { get; set; }

        public Student(string Name, string Surname, int Age, float Point) : base(Name,Surname, Age)
        {
            this.Point = Point;
        }
        public static bool operator <(Student Student1, Student Student2)
        {
            return Student1.Point < Student2.Point;
        }
        public static bool operator >(Student Student1, Student Student2)
        {
            return Student1.Point > Student2.Point;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nId:{Id}\nPoint: {Point}\n");
        }
        
    }
}
