using System;
using Task1_24._08._2022.Models;

namespace Task1_24._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher Teacher1 = new Teacher("Samad", "Muxtarov", 22, 600);
            Teacher Teacher2 = new Teacher("Rauf", "Muradov", 22, 300);
            Student Std1 = new Student("Elman", "Ceferov", 19, 86);
            Student Std2 = new Student("Teymur", "Shukurov", 23, 70);
            Student Std3 = new Student("Alim", "Ibrahimli", 16, 83);
            
            GroupMate P326 = new GroupMate();

            Person[] people = { Teacher1, Teacher2, Std1, Std2, Std3};
            int cnt = 0;
            foreach (Person item in people)
            {
                if(item is Student)
                {
                    Student student = (Student)item;
                    P326[cnt] = student;
                    cnt++;
                }

            }

            P326.Sort();
            
            try
            {
                for (int i = 0; i < cnt; i++)
                {
                    P326[i].ShowInfo();
                }

                if (Teacher1 > Teacher2) Console.WriteLine($"{Teacher1.Name} has more salary than {Teacher2.Name}\n");
                else Console.WriteLine($"{Teacher1.Name} has less salary than {Teacher2.Name}\n");

                Teacher1.ShowInfo();
                Teacher2.ShowInfo();

            }
            catch (Exception)
            {

                Console.WriteLine("The given index is bigger than the lengh of the Array.Please Enter a valid input!");
            }
            


        }
    }
}
