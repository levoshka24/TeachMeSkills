using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    delegate void DelOper();
    public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
    }
    public class Audi : Car {

        public override string Name { get => throw new NotImplementedException()    ; set => throw new NotImplementedException(); }
        public override string Description { get => throw new NotImplementedException()    ; set => throw new NotImplementedException(); }
        public int Dviglo { get; set; }
        public Audi(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void Say()
        {
            Console.WriteLine(Name);    
        }
    }

}
