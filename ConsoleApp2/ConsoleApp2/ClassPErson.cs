using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ClassPErson:Interface
    {
        private string name;
        private int height;
        public string Name { get { return name; } set { name = value; } }
        public void Walk()
        {
            Console.WriteLine("человек ходит");
        }
        public void Description()
        {
            Console.WriteLine("человек умеет ходить");
        }

    }
}
