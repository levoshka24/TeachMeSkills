using System.Diagnostics;
var time = new Stopwatch();
time.Start();
Console.WriteLine("input chislo cifr");
Random rnd = new Random();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив изначальный");
int[] a = new int[n];
int count = 0;
count += 2;
for (int i = 0; i < n; i++)
{
    count += 2;
    a[i] = rnd.Next(0, 5);
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
        if (a[j] == 0)
        {
            count += 2;
            var t = a[j];
            count += 2;
            a[j] = a[j + 1];
            count += 3;
            a[j + 1] = t;
            count += 3;
        }
    }
}


Console.WriteLine("\nОтсортированный массив");
count += 2;
for (int i = 0; i < n; i++)
{
    count += 2;
    Console.Write(a[i] + " ");
}
time.Stop();
Console.WriteLine($"\nПотраченное время - {time.Elapsed}");
Console.WriteLine($"Трудоемскость:  - {count}");