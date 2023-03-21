using System.Diagnostics;
int count = 0;
int counter = 0;

var time = new Stopwatch();

time.Start();
Console.WriteLine("input size");
int n = Convert.ToInt32(Console.ReadLine());

int[] mass = new int[n];
counter += 2;
counter += 2;
for (int i = 0; i < n; i++)
{
    counter += 2;
    mass[i] = Convert.ToInt32(Console.ReadLine());
    counter += 2;
}
counter += 2;
for (int i = 0; i < mass.Length; i++)
{
    counter += 2;
    counter += 2;
    for (int j = 0; j < mass.Length - i - 1; j++)
    {
        counter += 2;
        counter += 4;
        if (mass[j] > mass[j + 1])
        {
            int temp = mass[j];
            counter += 2;
            mass[j] = mass[j + 1];
            counter += 4;
            mass[j + 1] = temp;
            counter += 3;
        }
    }
}
Console.WriteLine("----------------------");
counter += 2;
for (int i = 0; i < n; i++)
{
    counter += 2;
    Console.WriteLine(mass[i]);
}
time.Stop();
Console.WriteLine($"Time Elapsed - {time.Elapsed}");