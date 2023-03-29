using System.Globalization;

Console.WriteLine("Введите рразмер матрицы A1");
int size = Convert.ToInt32(Console.ReadLine()); //вводим массив
int[,] A1 = new int[size, size];
int l = 0, m = 0;
Random rnd = new Random();
int[,] A2 = new int[l, m];
bool[] b = new bool[size];
Console.WriteLine("Введите элементы массива A1");
for (int i = 0; i < size; i++)
{
    b[i] = true;
    for (int j = 0; j < size; j++)
    {
        A1[i, j] = Convert.ToInt32(Console.ReadLine());
        if (b[i] && j > 0 && A1[i, j] < A1[i, j - 1]) b[i] = false;
    }
}
Console.Clear();
for (int i = 0; i < A1.GetLength(0); i++)
{
    for (int j = 0; j < A1.GetLength(1); j++)
        Console.Write("{0}\t", A1[i, j]);
    Console.WriteLine();
}
bool k = false;
for (int i = 0; i < size; i++)
    if (b[i])
    {
        k = true;
        Console.WriteLine("Строка №" + i);
    }
if (!k) Console.WriteLine("Нет строки отсортированной по возрастанию");

Console.WriteLine("Введите рразмер матрицы A3");
int size2 = Convert.ToInt32(Console.ReadLine()); //вводим массив
int[,] A3 = new int[size2, size2];

Console.WriteLine("Введите элементы массива A1");
for (int i = 0; i < size2; i++)
{
    
    for (int j = 0; j < size2; j++)
    {
        A3[i, j] = Convert.ToInt32(Console.ReadLine());
        
    }
}
Console.Clear();
for (int i = 0; i <size2; i++)
{
    for (int j = 0; j < size2; j++)
        Console.Write("{0}\t", A3[i, j]);
    Console.WriteLine();
}
int k1;
k1 = 0;
for (int j = 0; j < size2; j++)
{
    k1 = 0;
    for (int i = 0; i < size2 - 1; i++)
    {
        if(A3[i, j] > A3[i + 1, j])
        {
            k1 =k1 +  1;
            if (k1 == size2 - 1)
            {
                Console.WriteLine("stolbec" + j);
            }
        }
       

    }
 

}
