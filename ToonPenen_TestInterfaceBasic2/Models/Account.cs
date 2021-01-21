using System;
using ToonPenen_TestInterfaceBasic2.Interface;

namespace ToonPenen_TestInterfaceBasic2.Models
{
    public class Account : IAccount
    {
        private decimal balance = 0;
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Your depositetd is {amount}");
        }

        public decimal Balance
        {
            get
            {
                Console.WriteLine($"Your current balance is {balance} EURO.");
                return balance;
            }
        }

        public bool WithDrawFunds(decimal amount)
        {
            if (balance < amount)
            {

                Console.WriteLine($"your balance is smaller than {amount}");
                return false;
            }
            Console.WriteLine($"You asked {amount} EURO.");
            balance = balance - amount;
            return true;
        }
        bool IAccount.RudeLetterString(decimal amount)
        {
            if (amount > 10)
            {
                Console.WriteLine($"Tell Daddy yoy have overdrawn {amount}");
                return false;
            }
            Console.WriteLine($"You asked {amount} EURO.");
            balance = balance - amount;
            return true;

        }

        public void RudeLetterString() => Console.WriteLine($"this is {RudeLetterString}");
    }

}
