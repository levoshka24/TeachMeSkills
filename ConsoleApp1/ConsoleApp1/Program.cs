using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
int count = 0;
var time = new Stopwatch();
time.Start();
Console.WriteLine("Ведите точность, шаг, xнач, xконечн");
double e = double.Parse(Console.ReadLine());
double dx = double.Parse(Console.ReadLine());
double xstart = double.Parse(Console.ReadLine());
double xfinal = double.Parse(Console.ReadLine());
double y = 0;
double y2 = 0;
double t = 1;
double AbsoluteMistake;
double RelativeMistake;

int n = -1;
if (xfinal < 1)
{
    count++;
    Console.WriteLine("x       y2           y          AbsoluteMistake        RelativeMistake");
    count += 2;
    for (double x = xstart; x <= xfinal; x += dx)
    {
        count += 2;
        y = Math.Log(1 - x);
        count += 3;
        if (e > Math.Abs(x))
        {
            count += 2;
            y2 = -1 * x;
            count += 2;
        }
        else
        {
            n = 1;
            count++;
            t = x;
            count++;
            y2 = t;
            count++;
            while (Math.Abs(x) > t)
            {
                count += 2;
                n += 1;
                count += 2;
                t = t * x;
                count += 2;
                y2 = y2 + t / (n);
                count += 3;
            }
            y2 = y2 * -1;
            count += 2;
            AbsoluteMistake = (Math.Abs(y) - Math.Abs(y2));
            count += 4;
            RelativeMistake = AbsoluteMistake / y;
            count += 2;
            Console.WriteLine($"{Math.Round(x, 2)}      {Math.Round(y2, 5)}          {Math.Round(y, 5)}        {Math.Round(AbsoluteMistake, 5)}     {Math.Abs(Math.Round(RelativeMistake, 5))}");

        }
    }
}
else
{
    Console.WriteLine("Введены недопустимые данные");
    Console.Clear();
}
Console.WriteLine("Трудоемкость кода=" + count);
time.Stop();
Console.WriteLine($"Time spent:{time.Elapsed}");