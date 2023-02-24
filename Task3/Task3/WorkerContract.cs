using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class WorkerContract:Base_Contract
    {
        public override long NumberOfDocument { get; set; }
        public override DateTime DateOfDocument { get; set; }
        public DateTime DateOfEndContract { get; set; }
        public string Name { get; set; }
        public override void MakeContract()
        {
            Console.WriteLine("Введите имя сотрудника");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номер документа:");
            NumberOfDocument = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату документа");
            DateOfDocument = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату окончания контракта");
            DateOfEndContract = DateTime.Parse(Console.ReadLine());
        }
        public override void ShowContract()
        {
            Console.WriteLine($"Имя сотрудника - {Name}");
            Console.WriteLine($"Номер документа - {NumberOfDocument}");
            Console.WriteLine($"Дата документа - {DateOfDocument}");
            Console.WriteLine($"Дата окончания контракта - {DateOfEndContract}");
        }

    }
}
