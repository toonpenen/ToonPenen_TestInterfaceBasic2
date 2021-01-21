using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToonPenen_TestInterfaceBasic2.Interface;

namespace ToonPenen_TestInterfaceBasic2.Models
{
    public class YouthAccount : Account, IAccount
    {
        private decimal balance = 0;
       
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
            if (amount > 10)
            {
                Console.WriteLine("Tell your daddy you have overdrawn");
                return;
            }
            if (balance < 10)
            {
                balance = balance + amount;
                Console.WriteLine($"You deposited {amount} euro");
                
                return;
            }
            Console.WriteLine($"You deposited {amount} euro");
            Console.WriteLine($"you asked {amount} ");
            balance = balance - amount;
            true;
        }
    }
}
