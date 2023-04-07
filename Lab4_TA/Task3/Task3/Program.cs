using System.Diagnostics;
using System.Globalization;

Console.WriteLine("Введите рразмер матрицы A1");
var time = new Stopwatch();
time.Start();
int size = Convert.ToInt32(Console.ReadLine()); //вводим массив
int[,] A1 = new int[size, size];
int l = 0, m = 0;
Random rnd = new Random();
int[,] A2 = new int[l, m];
bool[] b = new bool[size];
Console.WriteLine("Введите элементы массива A1");
int count = 0;
count += 2;
for (int i = 0; i < size; i++)
{
    count += 2;
    b[i] = true;
    count++;
    count += 2;
    for (int j = 0; j < size; j++)
    {
        count += 2;
        A1[i, j] = Convert.ToInt32(Console.ReadLine());
        count += 4;
        if (b[i] && j > 0 && A1[i, j] < A1[i, j - 1]) b[i] = false;
        count += 11;
    }
}
Console.Clear();
count += 3;
for (int i = 0; i < A1.GetLength(0); i++)
{
    count += 3;
    count += 3;
    for (int j = 0; j < A1.GetLength(1); j++)
        Console.Write("{0}\t", A1[i, j]);
    Console.WriteLine();
}
bool k = false;
count++;
count += 2;
for (int i = 0; i < size; i++)
{
    count += 2;
    if (b[i])
    {
        count++;
        k = true;
        count++;
        Console.WriteLine("Строка №" + i);
    }
    if (!k)
    {
        count++;
        Console.WriteLine("Нет строки отсортированной по возрастанию");
    }
}

Console.WriteLine("Введите рразмер матрицы A3");
int size2 = Convert.ToInt32(Console.ReadLine()); //вводим массив
int[,] A3 = new int[size2, size2];

Console.WriteLine("Введите элементы массива A1");
count += 2;
for (int i = 0; i < size2; i++)
{
    count += 2;
    count += 2;
    for (int j = 0; j < size2; j++)
    {
        count += 2;
        A3[i, j] = Convert.ToInt32(Console.ReadLine());
        count += 4;

    }
}

count += 2;
for (int i = 0; i < size2; i++)
{
    count += 2;
    count += 2;
    for (int j = 0; j < size2; j++)
        Console.Write("{0}\t", A3[i, j]);
    Console.WriteLine();
}
int k1;
k1 = 0;
count++;
count += 2; ;
for (int j = 0; j < size2; j++)
{
    count += 2;
    k1 = 0;
    count++;
    count += 3;
    for (int i = 0; i < size2 - 1; i++)
    {
        count += 3;
        if (A3[i, j] > A3[i + 1, j])
        {
            count += 6;
            k1 = k1 + 1;
            count += 2;
            if (k1 == size2 - 1)
            {
                count += 2;
                Console.WriteLine("stolbec" + j);
            }
        }


    }


}
time.Stop();
Console.WriteLine($"Потраченное время - {time.Elapsed}");
Console.WriteLine($"Трудоемкость - {count}");