using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ContractForProduct:Base_Contract
    {
        public  string TypeOfProduct { get; set; }
        public override long NumberOfDocument { get; set; }
        public int KolvoOfProduct { get; set; }
        public override DateTime DateOfDocument { get; set; }
        
        public override void MakeContract()
        {
            Console.WriteLine("Введите номер документа:");
            NumberOfDocument = long.Parse(Console.ReadLine());
            Console.WriteLine("Введи тип продукта:");
            TypeOfProduct = Console.ReadLine();
            Console.WriteLine("Введите количество продукта");
            KolvoOfProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату документа");
            DateOfDocument = DateTime.Parse(Console.ReadLine());

        }
        public override void ShowContract()
        {
            Console.WriteLine($"Номер документа - {NumberOfDocument}");
            Console.WriteLine($"Тип продукта - {TypeOfProduct}");
            Console.WriteLine($"Количество - {KolvoOfProduct}");
            Console.WriteLine($"Дата - {DateOfDocument}");
        }

    }
}
