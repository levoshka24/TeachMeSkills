using System;

namespace TA_LR_6
{
    class Program
    {
        const int np = 10;

        delegate double Vect();

        static double Test(int n)
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
            double fe, ft, delta;
            Random rnd = new Random();

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("ne=");
            ne = int.Parse(Console.ReadLine());

            for (k = 1; k <= np; k++)
            {
                ft = Test(n);
                fe = Max(n, ne, () => rnd.NextDouble());
                delta = Math.Abs(ft - fe);
                Console.WriteLine();
                Console.WriteLine("k = {0,12}", k);
                Console.WriteLine("n = {0}", ne);
                Console.WriteLine("ft = {0,10:F8}", ft);
                Console.WriteLine("fe = {0,10:F8}", fe);
                Console.WriteLine("delta = {0,10:F8}", delta);
                //ne *= 10; 
            }
        }

        static void Main(string[] args)
        {
            Count();
        }
    }
}