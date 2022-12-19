using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Student
    {
        public int points;
        public string name;
        public string surname;
        public string group;
        public bool isGraduated;

        public void nameAndSurname()
        {            
                Console.WriteLine($"Ad:{this.name}, Soyad:{this.surname}");

        }
    
        public void showEverything()
        {
            Console.WriteLine($"Ad Soyad:{this.name} {this.surname}, Qrup: {this.group}, Mezun olmaq statusu: {this.isGraduated}, Bali:{this.points}");

            if (this.isGraduated == true)
            {
                Console.WriteLine("Telebe mezun olmushdur");
            }
            else
            {
                Console.WriteLine("Telebe kesilib");
            }
        }
        public void canTakeExam()
        {
            if (this.points > 80)
            {
                Console.WriteLine("Ikinci defe imtahan vere bilersiniz.");
            }
            else
            {
                Console.WriteLine("Ikinci defe imtahan vermek shansiniz yoxdur.");
            }
        }
        
        public Student(int points,string name, string surname, string group)
        {
            if (points > 0 && points <= 100)
            {
                this.points = points;
                this.name = name;
                this.surname = surname;
                this.group = group;
                if (points > 50)
                {
                    this.isGraduated = true;
                }
                else
                {
                    this.isGraduated = false;
                }
            }
            else
            {
                Console.WriteLine("Telebenin bali 0-100 intervalinda olmalidir");
            }
            
        }
        public Student()
        {
            Console.WriteLine("Please enter these values: points, name, surname, group, isGraduated");
        }
    }
}
