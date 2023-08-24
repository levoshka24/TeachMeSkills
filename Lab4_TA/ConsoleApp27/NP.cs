using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    delegate void DelOper();
    public interface IRide
    {
        public void Rider();
    }
    public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract void Dviglo();
    }
    public class Audi : Car ,IRide
    {
        public override string Name { get; set; }
        public override void Dviglo()
        {
            Console.Write(Name);
        }
        public void Ride()
        {
            Console.WriteLine();
        }
    }

}
