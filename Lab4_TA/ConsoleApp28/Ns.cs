using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    delegate void DelOper();
    public interface IDrive
    {
        public void Drive();
    }
    public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
    }
    public class Audi : Car,IDrive
    {
        public override string Name { get; set; } = "Audi";
        public override string Description { get => throw new NotImplementedException() ; set => throw new NotImplementedException(); }
        public string Color { get; set; }
       public void Say()
        {
            Console.WriteLine("This evr here");
        }
        public void Drive()
        {
            Console.WriteLine("Drive");
        }
    }

}
