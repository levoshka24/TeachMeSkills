using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    delegate void SayDelegate();
    public interface IDviglo
    {
        public void SayDviglo();
    }
   public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract void Say();
    }
    public class Audi : Car,IDviglo
    {
        public override string Name { get; set; }
        public override string Color { get; set; }
        public int Dviglo { get; set; }
        public override void Say()
        {
            Console.WriteLine(Name);
        }
        public void SayDviglo()
        {
            Console.WriteLine(Dviglo);
        }
    }
    public class BMW : Car, IDviglo
    {
        public override string Name { get; set; }
        public override string Color { get; set; }
        public int Dviglo { get; set; }
        public override void Say()
        {
            Console.WriteLine(Color);
        }
        public void SayDviglo()
        {
            Console.WriteLine(Dviglo);
        }

    }

}
