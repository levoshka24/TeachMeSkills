using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle:Figure
    {
       public double X { get; set; }
       public double Y { get; set; }
       public int Z { get; set; }
       public Triangle(double x, double y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override double Square()
        {
            return (X / Y) / 2;
        }
        public override double Perimetr()
        {
            return X+Y+Z;
        }
    }
}
