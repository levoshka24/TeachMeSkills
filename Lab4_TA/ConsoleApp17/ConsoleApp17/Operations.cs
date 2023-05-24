using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    
   public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract void Description();
    }
    public class Audi : Car
    {
        public override string Name { get; set; }
        public override string Color { get; set; }
        public int dviglo;
        public override void Description()
        {
            Console.WriteLine(dviglo);
        }
    }
    public class BMW:Car
    {
        public override string Name { get; set; }
        public override string Color { get; set; }
        public int dviglo;
        public override void Description()
        {
            Console.WriteLine(Name);
            Console.WriteLine("mfmmf");
        }
    }
    public class Oper<T>
    {
        public T Value { get; set; }
        public void Desc()
        {
            Console.WriteLine(Value);
        }
    }
    
}
