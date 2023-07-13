using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
   
    public abstract class Car { 
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
    
    
    }
    public class Audi : Car
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public int Dviglo { get; set; }
    }
}
