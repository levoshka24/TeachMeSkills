//TASK 1
Console.WriteLine("Введите номер месяца: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("зима");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("весна");
        break;
    case 7:
    case 8:
    case 9:
        Console.WriteLine("лето");
        break;
    case 10:
    case 11:    
    case 12:
        Console.WriteLine("осень");
        break;
    default:
        Console.WriteLine("вы ввели что то не то");
        break;

}
//TASK 2
Console.WriteLine("Введите номер месяца: ");
int chislo = int.Parse(Console.ReadLine());
if (chislo == 1 || chislo == 2 || chislo == 3) { Console.WriteLine("зима"); }
if (chislo == 4 || chislo == 5 || chislo == 6) { Console.WriteLine("весна"); }
if (chislo == 7 || chislo == 8 || chislo == 9) { Console.WriteLine("лето"); }
if (chislo == 10 || chislo == 11 || chislo == 12) { Console.WriteLine("осень"); }
//TASK 3
Console.WriteLine("Введите число: ");
int ch = int.Parse(Console.ReadLine());
if (ch % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
//TASK 4
Console.WriteLine("введите температуру");
int t = int.Parse(Console.ReadLine());
if (t > -5)
{
    Console.WriteLine("тепло");
}
else if (t <= -5 && t > -20)
{
    Console.WriteLine("Нормально");
}
else if (t <= -20)
{
    Console.WriteLine("холодно");
}
//TASK 5
Console.WriteLine("введите цифру");
int r = int.Parse(Console.ReadLine());
switch (r)
{
    case 1:
        Console.WriteLine("красный");
        break;
    case 2:
        Console.WriteLine("оранжевый");
        break;
    case 3:
        Console.WriteLine("желтый");
        break;
    case 4:
        Console.WriteLine("зеленый");
        break;
    case 5:
        Console.WriteLine("голубой");
        break;
    case 6:
        Console.WriteLine("синий");
        break;
    case 7:
        Console.WriteLine("фиолетовый");
        break;
    default:
        Console.WriteLine("вы ввели ерунду");
        break;
}