using System.Diagnostics;
var time = new Stopwatch();
time.Start();
Console.WriteLine("input chislo cifr");
Random rnd = new Random();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив изначальный");
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = rnd.Next(0,5);
}
for (int i = 0; i < n; i++)
{
    Console.Write(a[i] + " ");
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (a[j]==0)
        {
            var t = a[j];
            a[j] = a[j + 1];
            a[j + 1] = t;
        }
    }
}


Console.WriteLine("\nОтсортированный массив");
for (int i = 0; i < n; i++)
{
    Console.Write(a[i] + " ");
}
time.Stop();
Console.WriteLine($"\nПотраченное время - {time.Elapsed}");