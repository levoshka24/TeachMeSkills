//TASK 1
using System.Diagnostics;
var time = new Stopwatch();
time.Start();
Console.WriteLine("input chislo cifr");
Random rnd = new Random();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сам массив");
int[] a = new int[n];
int count = 0;
count += 2;
for (int i = 0; i < n; i++)
{
    count += 2;
    a[i] = rnd.Next(15);
    count += 3;
}
count += 2;
for (int i = 0; i < n; i++)
{
    count += 2;
    Console.Write(a[i] + " ");
}
count += 2;
for (int i = 0; i < n; i++)
{
    count += 2;
    count += 3;
    for (int j = 0; j < n - 1; j++)
    {
        count += 3;
        if (a[j] > a[j + 1])
        {
            count += 4;
            var t = a[j];
            count += 2;
            a[j] = a[j + 1];
            count += 4;
            a[j + 1] = t;
            count += 3;
        }
    }
}
Console.WriteLine("\n----------------");
Console.WriteLine("Отсортированный массив");
count += 2;
for (int i = 0; i < n; i++)
{
    count += 2;
    Console.Write(a[i] + " ");
}
time.Stop();
Console.WriteLine($"Потраченное время - {time.Elapsed}");
Console.WriteLine($"Трудоемкость - {count}");
Console.WriteLine("-----------------------------------");
Console.WriteLine("2 метод сортировки");
var time2 = new Stopwatch();
time2.Start();
int count2 = 0;
//метод для обмена элементов
static void Swap(ref int a, ref int b)
{
    var t = a;
    a = b;
    b = t;
}
void Print(int[] mass)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(mass[i] + " ");
    }

}
//стоящие оддин от другого на некотором растоянии д.после этого процедура повт для меньш значений а завершается упораяд эл при д =1
int[] ShellSort(int[] array)
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
                Console.WriteLine("|");
                Swap(ref array[j], ref array[j - d]);
                j = j - d;
                Print(array);
                
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
count2 += 3;
for (int i = 0; i < array.Length; i++)
{
    count2 += 3;
    array[i] = rnd.Next(0, 100);
    count2 += 3;
}


Console.WriteLine("\nОтсортированный массив: {0}", string.Join(", ", ShellSort(array)));
time2.Stop();
Console.WriteLine($"Потраченное время - {time2.Elapsed}");
Console.WriteLine($"Трудоемкость - {count2}");
Console.ReadLine();