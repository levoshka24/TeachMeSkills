using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Dog:Animal
    {
        public string color;
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override void Say()
        {
            Console.WriteLine("gau");
        }
        public Dog(string color, string name, string description)
        {
            this.color = color;
            Name = name;
            Description = description;
        }
    }
}
