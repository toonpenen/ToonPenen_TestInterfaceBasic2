using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToonPenen_TestInterfaceBasic2.Interface;

namespace ToonPenen_TestInterfaceBasic2.Models
{
    public class CostumerAccount:Account, IAccount
    {
        decimal IAccount.GetBalance { get;}

        public new bool WithDrawFunds(decimal amount);


        void IAccount.RudeLetterString();
        
    }
}
