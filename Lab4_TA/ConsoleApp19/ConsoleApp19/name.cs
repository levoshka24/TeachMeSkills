using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    delegate void Del();
    public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract string Weight { get; set; 
    }
        public class Audi : Car
        {
            public override string Name { get; set; }
            public override string Weight { get; set; }
        }
}
