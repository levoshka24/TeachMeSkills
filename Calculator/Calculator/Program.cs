// CALCULATOR
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Вас приветствует калькулятор");
Console.WriteLine("----------------------------");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Вот что наш калькулятор может");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("1-Сложение");
Console.WriteLine("2-Вычитание");
Console.WriteLine("3-Деление");
Console.WriteLine("4-Умножение");
Console.WriteLine("5-Процент от числа");
Console.WriteLine("6-Квадратный корень из числа");
Console.WriteLine("----------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите первое число");
double q = int.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Введите второе число");
double f = int.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Введите какая операция вас интересует");
int l = int.Parse(Console.ReadLine());
switch (l)
{
    case 1:
        double s = q + f;
        Console.WriteLine($"{q} + {f} = {s}");
        break;

    case 2:
        double z = q - f;
        Console.WriteLine($"{q} - {f} = {z}");
        break;
    case 3:
        double d = q / f;
        Console.WriteLine($"{q} / {f} = {f}");
        break;
    case 4:
        double x = q * f;
        Console.WriteLine($"{q} * {f} = {x}");
        break;
    case 5:
        double m = q % f;
        Console.WriteLine($"{q} % {f} = {m}");
        break;
    case 6:
        Console.WriteLine("Введите число из которого вы хотите получить корень");
        int u = int.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {Math.Abs(u)}");
        break;
    default:
        Console.WriteLine("что то не то ввели");
        break;
}
Console.ReadLine();