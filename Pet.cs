using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Pet
    {
        private String name;
        private int energy;
        public String nameCheck
        {
            get
            {
                return name;
            }
            set
            {
               name = value;
            }
        }
       
        public int energyCheck
        {
            get
            {
                return energy;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    energy = value;
                }
                else
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                    return;
                    
                }


            }
        }
        public void Rest()
        {
            energy += 30;
            Console.WriteLine($"{name} отдыхает, энергия: {energy}");
        }
        public void Play()
        {
            energy -= 20;
            Console.WriteLine($"{name} играет, энергия: {energy}");
        }


    }
}

