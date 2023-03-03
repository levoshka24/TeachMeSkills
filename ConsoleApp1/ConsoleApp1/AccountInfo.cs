using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccountInfo
    {
        private int accountId;
        private string name;
        private decimal deposit;
        private char accounttype;
        private DateTime openDates;
        public AccountInfo()
        {
            openDates = DateTime.Now;
        }
        public int AccountId { get { return accountId; } set { accountId = value; } }
        public char AccountType { get { return accounttype; } set { accounttype = value; } }
        public decimal Deposit { get { return deposit; } set { deposit = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
