using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
    public class Animal
    {
        public string Color { get; set; }
        public virtual void Voice()
        {
            Console.WriteLine("у всех животных разные звуки");
        }
    }
}
