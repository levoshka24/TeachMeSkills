//1 Подсчитать среднее арифметическое ненулевых элементов,
//расположенных над побочной диагональю.
//2 Определить существуют ли в массиве строки не содержащие нулевых
//элементов
using System;
using System.IO;
using System.Text;

static int[,] ArrayInput(string path)
{
    using (FileStream fs = new FileStream(path, FileMode.Open))
    {
        using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
        {
            byte[] buffer = new byte[sizeof(int)];
            int getlenght0 = br.ReadInt32();
            int getlenght1 = br.ReadInt32();
            var array = new int[getlenght0, getlenght1];
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    br.Read(buffer, 0, sizeof(int));
                    array[i, j] = BitConverter.ToInt32(buffer, 0);
                }
            }
            return array;
        }
    }
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
static double SredneeZero(int[,] a)
{
    double count = 0;
    double count1 = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i + j < a.GetLength(0) - 1)
            {
                count += a[i, j];
                count1 += 1;
            }
        }
    }
    return count / count1;
}
static int CountOfStrok(int[,] a)
{
    int shet = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int s = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == 0)
            {
                s += 1;
            }
        }
        if (s == 0) shet++;
    }

    return shet;
}





Console.WriteLine("Исходный массив");
string inputpath = "Array.bin";
int[,] array = {
{ 1, 2, 3 },
{ 4, 5, 6 },
{ 7, 8, 9 }
 };
using (FileStream fs = new FileStream(inputpath, FileMode.Create))
{
    using (BinaryWriter bw = new BinaryWriter(fs))
    {

        bw.Write(array.GetLength(0));
        bw.Write(array.GetLength(1));
        byte[] b;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                b = BitConverter.GetBytes(array[i, j]);
                bw.Write(b, 0, b.Length);
            }
        }
    }
}
int[,] array2 = ArrayInput(inputpath);

Output(array2);
double srednee = SredneeZero(array2);
int countofstrok = CountOfStrok(array2);
Console.WriteLine($"Среднее элементов главной диагонали - {srednee}");
Console.WriteLine($"Количество не нулевых строк - {countofstrok}");
using (var fs = new FileStream("results.bin", FileMode.Create))
{
    using(BinaryWriter bw = new BinaryWriter(fs))
    {
        bw.Write($"Среднее элементов главной диагонали - {srednee}");
    }
}
using (var fs = new FileStream("res.bin", FileMode.Create))
{
    using (BinaryWriter bw = new BinaryWriter(fs))
    {
        bw.Write($"Количество не нулевых строк - {countofstrok}");
    }
}