using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinanceContract:Base_Contract
    {
        public override long NumberOfDocument { get; set; }
        public override DateTime DateOfDocument { get; set; }
        public long MoneyAll { get; set; }
        public long DepartmentCode { get; set; }
        public override void MakeContract()
        {
            Console.WriteLine("Введите номер документа:");
            NumberOfDocument = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату документа:");
            DateOfDocument = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите итоговую сумму за месяц:");
            MoneyAll = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите код департамента:");
            DepartmentCode = long.Parse(Console.ReadLine());
        }
        public override void ShowContract()
        {
            Console.WriteLine($"Номер документа - {NumberOfDocument}");
            Console.WriteLine($"Дата документа - {DateOfDocument}");
            Console.WriteLine($"Итоговая сумма - {MoneyAll}");
            Console.WriteLine($"Код департамента - {DepartmentCode}");
        }
    }
}
