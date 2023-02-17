using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW_2
{
    public class CreditCard
    {
        public long number = 52208130004775387;
        public long cash = 5000;
        public void Add_Money(int add_money)
        {
            
            
            long d = cash + add_money;
            Console.WriteLine($"Теперь на счету - {d}");
        }
        public void Take_Cash(int take_money)
        {
            
            long d = cash - take_money;
            Console.WriteLine($"Теперь на счету - {d}");
        }
    }
    
}
