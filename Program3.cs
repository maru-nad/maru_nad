using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.ownerCheck = "Иван";
            account.balanceCheck = 1000;

            account.Deposit(50.0);
            account.Withdraw(20.0);
            account.Withdraw(15000); 
        }
    
    }
}
