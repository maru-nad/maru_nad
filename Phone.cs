using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Phone
    {
        private String brand;
        private int batteryLevel;
        public String brandCheck
        {
            get {return brand;}
            set {brand = value;}
        }
        public int batteryLevelCheck
        {
            get {return batteryLevel;}
            set
            {
                if (value >= 0 && batteryLevel <= 100)
                {
                    batteryLevel = value;
                }
                else
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                }
            }
        }
        public void UsePhone()
        {
            batteryLevel -= 10;
            if (batteryLevel <= 0)
            {
                batteryLevel = 0;
            }
            Console.WriteLine($"Телефон {brand}, заряд:{batteryLevel}%");
        }
    }
}
