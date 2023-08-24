using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    delegate void DelOper(string mess);
    public interface IDrive
    {
        public void Drive(int engine);
    }
    public abstract class Car
    {
        public abstract int Name { get;set; }
        public abstract string Description { get; set; }
    }
    public class Audi : Car,IDrive {
        public override int Name { get; set; }
        public override string Description { get; set; }
        public int Engine { get; set; }
        public void Say()
        {
            Console.WriteLine("Big dick");
        }
        public void Drive(int engine)
        {
            Console.WriteLine("YEs");
        }
    
    }

}
