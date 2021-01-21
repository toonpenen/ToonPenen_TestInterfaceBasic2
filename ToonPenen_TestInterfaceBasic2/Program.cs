using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToonPenen_TestInterfaceBasic2.Interface;
using ToonPenen_TestInterfaceBasic2.Models;

namespace ToonPenen_TestInterfaceBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount CostumerAccount = new CostumerAccount();
            CostumerAccount.PayInFunds(100.00M);
            CostumerAccount.WithDrawFunds(50);
            CostumerAccount.Balance;

        
            Console.WriteLine("--------------------------------");
            
            IAccount YouthAccount = new Youth_Account();
            YouthAccount.PayInFunds(500);
            YouthAccount.WithDrawFunds(10);
            _ = YouthAccount.Balance;

            IAccount[] accounts = new IAccount[] { CostumerAccount, YouthAccount };


            

       
            CustomerAccount customer = new CustomerAccount();
            customer.PayInFunds(100.00M);


            Console.WriteLine(customer.GetBalance());

            Console.WriteLine(customer.WithDrawFunds(50M));

            Console.WriteLine(customer.GetBalance());

            Console.WriteLine("=========================================");


            Youth_Account YouthAccount = new Youth_Account();
            YouthAccount.PayInFunds(100.00M);
            Console.WriteLine(YouthAccount.Balance);
            Console.WriteLine(YouthAccount.WithDrawFunds(9M));
            Console.WriteLine(YouthAccount.Balance);



            Console.ReadLine();


        }
    }
}
