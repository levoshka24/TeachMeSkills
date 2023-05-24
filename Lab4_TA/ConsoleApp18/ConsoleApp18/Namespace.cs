using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    delegate void Delegateoper();
    public class Write<T>
    {
        T  
    }
   public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract void Say();
    }
    public class Cat:Animal
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override void Say()
        {
            Console.WriteLine();
        }
    }
}
