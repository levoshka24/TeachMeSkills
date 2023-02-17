using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
    public class Cat1:Animal
    {
        public string Name { get; set; } = "lola";
        
        public override void Voice()
        {
            Console.WriteLine("я мяукаю");
        }
    }
}
