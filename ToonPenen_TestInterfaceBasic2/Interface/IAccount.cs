using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToonPenen_TestInterfaceBasic2.Interface
{
    public interface IAccount
    {
        void PayInFunds(decimal amount); 
        bool WithDrawFunds(decimal amount);
        decimal Balance { get; }

        void RudeLetterString(); 
        
        
        
        
        
        
    }
}
