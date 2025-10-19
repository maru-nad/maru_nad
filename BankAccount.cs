using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class BankAccount
    {
        private String owner;
        private double balance;
        public String ownerCheck
        {
            get { return owner; }
            set
            {
                owner = value;
            }
        }
        public double balanceCheck
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс не должен быть меньше 100.");
                    return;
                }

            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{owner}, баланс: {balance}.");
            }
            else
            {
                Console.WriteLine("Ошибка: Сумма депозита должна быть больше 0.");
                return ;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"{owner}, баланс: {balance}.");
                }
                else
                {
                    Console.WriteLine("Ошибка: Недостаточно средств на счете.");
                    return ;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Сумма снятия должна быть больше 0.");
                return;
            }
        }
    }
}
