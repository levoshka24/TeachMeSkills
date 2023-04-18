using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Cat:Animal
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override void Say()
        {

            Console.WriteLine("myau");

        }
        public Cat(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
