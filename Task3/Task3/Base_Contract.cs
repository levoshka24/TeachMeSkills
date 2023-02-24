using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract public class Base_Contract
    {
        public abstract long NumberOfDocument { get; set; }
        public abstract DateTime DateOfDocument { get; set; }
        public abstract void MakeContract();
        public abstract void ShowContract();

    }
}
