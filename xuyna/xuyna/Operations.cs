using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuyna
{
    static public class Operations
    {
        static public void Pow(int x,int stepen)
        {
            int d = 1;
            for(int i = 0; i < stepen; i++)
            {
                d*=x;
            }
            Console.WriteLine(d);
        }
        static public void Abs(int l)
        {
            if (l > 0)
            {
                Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine(-1*l);
            }
        }
    }
}
