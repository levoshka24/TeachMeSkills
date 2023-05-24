using System;

namespace _6
{
    class Program
    {
        delegate double Vect();
        static double Hn(int n)
        {
            double s = 0.0;
            for (int i = 1; i <= n; i++)
            {
                s += 1.0 / (double)i;
            }
            return s;
        }
        static double Max(int n, int ne, Vect rnd)
        {
            double sc = 0.0;
            for (int i = 1; i <= ne; i++)
            {
                double[] r = new double[n];
                for (int j = 0; j < n; j++)
                {
                    r[j] = rnd();
                }
                sc += 1.0; // count max
                double mx = r[0];
                for (int j = 1; j < n; j++)
                {
                    if (mx < r[j])
                    {
                        mx = r[j];
                        sc += 1.0;
                    }
                }
            }
            return sc / (double)ne;
        }
        static void Count()
        {
            int n, ne, k;
            double fe, ft, sigma;
            Random rnd = new Random();

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("ne=");
            ne = int.Parse(Console.ReadLine());
            for (k = 1; k <= 10; k++)
            {
                ft = Hn(n);
                fe = Max(n, ne, () => rnd.NextDouble());
                sigma = Math.Abs(ft - fe);
                Console.WriteLine();
                Console.WriteLine("k = {0}", k);
                Console.WriteLine("ne = {0}", ne);
                Console.WriteLine("ft = {0,10}", ft);
                Console.WriteLine("fe = {0,9}", fe);
                Console.WriteLine("sigma = {0,10}", sigma);
            }
        }
        static void Main(string[] args)
        {
            Count();
        }
    }
}