using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.brandCheck ="Samsung";
            phone.batteryLevelCheck =0;
            phone.UsePhone();
            phone.UsePhone();
        }
    }
}
