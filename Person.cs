using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Person
    {
        private String name;
           private int age; 
        public String nameCheck
        {
            get { return name; }
            set
            {
              name = value;
            }
        }
        public int ageCheck
        {
            get { return age; }
            set
            {
                if (value>=0&&value<=120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть в диапазоне от 0 до 120.");
                    return;
                }

            }
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {name}, мне {age} лет!");
        }
    }
}
