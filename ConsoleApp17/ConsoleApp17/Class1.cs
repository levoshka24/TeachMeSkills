using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Classica<T>
    {
        public T value;
        public void Say<T>()
        {
            Console.WriteLine(value);
        }
    }
}
