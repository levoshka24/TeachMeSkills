using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ITransaction
    {
        public void Createaccount();
        //public void Updateaccount(int AccountID);
        public void Showaccount();
        //public void MoneyDeposit();
        //public void MoneyVivod();
        //public void AccountReport();
    }
}
