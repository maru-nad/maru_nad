using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            pet.nameCheck = "Бобик";
            pet.energyCheck = 40;
            pet.Play();
            pet.Rest();
        }
    }
}
