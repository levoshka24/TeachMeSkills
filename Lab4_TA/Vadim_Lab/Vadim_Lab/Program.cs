using Vadim_Lab;

static void OutputData (Line line)
{
    Console.WriteLine($"x = {line.start.x}, y = {line.start.y}");
    Console.WriteLine($"x = {line.end.x}, y = {line.end.y}");
}

static void OutputColor (Line line)
{
    Console.WriteLine($"{line.color}");
}

static Line InputData ()
{
    Line line = new Line();
    Console.Write("Начало отрезка (x)   = ");
    line.start.x = Double.Parse(Console.ReadLine());
    Console.Write("Начало отрезка (y)   = ");
    line.start.y = Double.Parse(Console.ReadLine());
    Console.Write("Конец отрезка  (x)   = ");
    line.end.x = Double.Parse(Console.ReadLine());
    Console.Write("Конец отрезка  (y)   = ");
    line.end.y = Double.Parse(Console.ReadLine());
    Console.Write("Цвет отрезка (color) =  ");
    line.color = Console.ReadLine();
    return line;
}
static double LineLength (Line line)
{
    double d = Math.Sqrt(Math.Pow(line.start.x - line.end.x,2)+Math.Pow(line.start.y - line.end.y,2));
    return d;
}
static bool LineParallelism(Line line1, Line line2)
{
    var k1 = (line1.end.y - line1.start.y) / (line1.end.x - line1.start.x);
    var k2 = (line2.end.y - line2.start.y) / (line2.end.x - line2.start.x);
    if (k1==k2)
    {
        return true;
    }
    return false;
}

Console.Write($"Количество отрезков = ");
int n = int.Parse(Console.ReadLine());
Line[] lines = new Line[n];
for (var i = 0; i<n; i++)
{
    Console.WriteLine($"Отрезок номер {i+1}");
    lines[i] = InputData();
}
for (var i = 0; i<n; i++)
{
    for (var j = i+1; j<n; j++)
    {
        if (LineParallelism(lines[i], lines[j]) == true)
        {
            Console.WriteLine($"Отрезок {i+1} и отрезок {j+1} параллельны");
            OutputData(lines[i]);
            OutputColor(lines[i]);
            OutputData(lines[j]);
            OutputColor(lines[j]);
        }
    }
}
Console.WriteLine("Длины всех отрезков");
var maxLine = 0;
for (var i = 0; i<n; i++)
{
    Console.WriteLine($"Отрезок {i + 1} = {LineLength(lines[i])}");
}
for (var i = 1; i < n; i++)
{
    if (LineLength(lines[i]) > LineLength(lines[i - 1]))
    {
        maxLine = i;
    }
}
Console.WriteLine($"Самый длинный отрезок - отрезок {maxLine+1}, его цвет: ");
OutputColor(lines[maxLine]);
