using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Operations:INumberOfOperations
    {
        public void Factorial(out int res)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) Console.WriteLine("1");
            int p = 1;
            for(int i =1; i <= n; i++)
            {
                p *= i;
            }
            res = p;
        }
        public bool IsPositive()
        {
            Console.WriteLine("Введите число:");
            int figure = Convert.ToInt32((Console.ReadLine()));
            if (figure > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int NumberOfPermutations()
        {
            Console.WriteLine("Введите количество обьектов");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число обьектов для перестановки");
            int m = Convert.ToInt32((Console.ReadLine()));
            int p = 1;
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                p =p* i;
            }
            int factorial_n = p;
            int d = n - m;
            for (int j = 1; j <= d; j++)
            {
                f =f* j;
            }
            int factorial_d = f;
            return factorial_n / factorial_d;
        }
    }
}
