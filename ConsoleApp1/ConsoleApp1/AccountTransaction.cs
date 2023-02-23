using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class AccountTransaction:AccountInfo,ITransaction
    {
        public void Createaccount()
        {
            Console.WriteLine("----Введи информацию об аккаунте------");
            Console.WriteLine("Введите accountId:");
            AccountId = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя аккаунта:");
            Name = Console.ReadLine();
            Console.WriteLine("введите тип аккаунта комерч/персональный:");
            AccountType = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите депозит:");
            Deposit = decimal.Parse(Console.ReadLine());
        }
        public void Showaccount()
        {
            Console.WriteLine("----Введи информацию об аккаунте------");
            Console.WriteLine($"AccountId - {AccountId}");
            Console.WriteLine($"Account Name - {Name}");
            Console.WriteLine($"Account Type - {AccountType}");
            Console.WriteLine($"Account Deposit - {Deposit}");
        }
    }

}

