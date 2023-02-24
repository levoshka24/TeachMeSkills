
// TASK 3
static int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}
static bool IsPositive(int figure)
{
    if (figure > 0)
    {
        return true;
    }
    else
    {
        return false;

    }
}
static int NumberOfPermutations(int n, int m)
{
    int factorial_n = Factorial(n);
    int d = n - m;
    int factorial_d = Factorial(d);
    return factorial_n / factorial_d;
}
Console.WriteLine("Введите количество обьектов");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
bool ispositive_n = IsPositive(n);
Console.WriteLine("Введите число обьектов для перестановки");
int m = int.Parse(Console.ReadLine());
bool ispositive_m = IsPositive(m);
Console.WriteLine("------------------");
if (ispositive_n & ispositive_m)
{
    int result = NumberOfPermutations(n, m);
    string result1 = string.Format($"Число комбинаций  = {result}");
    Console.WriteLine(result1);
}
else
{
    Console.WriteLine("Вы ввели неверные данные");
}
