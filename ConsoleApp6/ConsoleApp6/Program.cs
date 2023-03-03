using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

static int[,] Input2()
{
    Console.WriteLine("Введите размерности двумерного массива: ");
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    int[,] a = new int[n, m];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
        {
            Console.Write("Введите элемент {0}-ой строки {1}-го столбца:", i + 1, j + 1);


            a[i, j] = int.Parse(Console.ReadLine());
        }
    return a;
}
static void Output(int[,] a)
{

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write("{0}\t", a[i, j]);
        Console.WriteLine();
    }
}
static int FindMax(int[,] a)
{
    int max = 0;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] > max)
            {
                max =a[i, j];
            }
        }
    }
    return max;
}
static int FindMin(int[,] a)
{
    int min = a[0,0];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] < min)
            {
                min = a[i, j];
            }
        }
    }
    return min;
}
int[,] d = Input2();
Output(d);
int c = FindMax(d);
Console.WriteLine($"Максимальное - {c}");
int s = FindMin(d);         
Console.WriteLine($"Минимальное - {s}");
int f = c - s;
Console.WriteLine($"Разность максимального и минимального  - {f}");
for (int y = 0; y < d.GetLength(1); y++)
{
    for (int i = 0; i < (d.GetLength(1) - 1); i++)
    {
        if (d[i, 0] > d[i + 1, 0])
        {
            for (int j = 0; j < d.GetLength(0); j++)
            {
                var x = d[i, j];
                d[i, j] = d[i + 1, j];
                d[i + 1, j] = x;
            }
        }
    }
}
Output(d);