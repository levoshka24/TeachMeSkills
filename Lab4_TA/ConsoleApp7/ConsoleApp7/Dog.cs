using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Dog:Animal
    {
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override void Description()
        {
            Console.WriteLine(Name);
        }

    }
}
