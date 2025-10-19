using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Circle
    {
        private double radius;
        public double radiusCheck
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Радиус должен быть больше 0.");
                    return;
                }

            }
        }
        public void GetArea()
        {
            double S;
            S= Math.PI * radius*radius;
            Console.WriteLine($"Площадь:{S}");
        }
    }
}
