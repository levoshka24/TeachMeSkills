using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
   public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract void Description();
    }
}
