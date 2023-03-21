using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Dog:Animal
    {
        public override string Name { get; set; }
        public override void Say()
        {
            Console.WriteLine("gav gav gav");
        }
    }
}
