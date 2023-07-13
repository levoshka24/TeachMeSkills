using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    delegate void DelegateOper(string message);
    public interface IDrive
    {
        public void Drive();
    }
    public abstract class Car 
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
    }
    public class Audi : Car, IDrive
    {
        public override string Name { get; set; } 
        public override string Description { get; set; }
        public void Drive()
        {
            Console.WriteLine("I am driving");
        }
    }
    
}
