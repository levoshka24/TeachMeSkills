//TASK 1
using System.Diagnostics;
var time = new Stopwatch();
time.Start();
Console.WriteLine("input chislo cifr");
Random rnd = new Random();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сам массив");
int[] a = new int[n];
for(int i = 0; i < n; i++)
{
    a[i] = rnd.Next(15);
}
for(int i = 0; i < n; i++)
{
    Console.Write(a[i] + " ");
}
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < n-1; j++)
    {
        if (a[j] > a[j + 1])
        {
            var t = a[j];
            a[j] = a[j + 1];
            a[j + 1] = t;
        }
    }
}
Console.WriteLine("\n----------------");
Console.WriteLine("Отсортированный массив");
for(int i = 0; i < n; i++)
{
    Console.Write(a[i] + " ");
}
time.Stop();
Console.WriteLine($"Потраченное время - {time.Elapsed}");
Console.WriteLine("-----------------------------------");
Console.WriteLine("2 метод сортировки");
var time2 = new Stopwatch();
time2.Start();
//метод для обмена элементов
static void Swap(ref int a, ref int b)
{
    var t = a;
    a = b;
    b = t;
}

static int[] ShellSort(int[] array)
{
    //расстояние между элементами, которые сравниваются
    var d = array.Length / 2;
    while (d >= 1)
    {
        for (var i = d; i < array.Length; i++)
        {
            var j = i;
            while ((j >= d) && (array[j - d] > array[j]))
            {
                Swap(ref array[j], ref array[j - d]);
                j = j - d;
            }
        }

        d = d / 2;
    }

    return array;
}
Console.WriteLine("Сортировка Шелла");
Console.Write("Введите  кол-во элементы массива: ");
int n2 = Convert.ToInt32(Console.ReadLine());
var array = new int[n2];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(15);
}
for(int i=0; i < n2; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("\nОтсортированный массив: {0}", string.Join(", ", ShellSort(array)));
time.Stop();
Console.WriteLine($"Потраченное время - {time2.Elapsed}");
Console.ReadLine();
