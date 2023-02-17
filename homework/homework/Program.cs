//// TASK 1
///
// Разработать метод вычисления факториала. Создать void метод с той
//же функциональностью
//static bool IsPositive(int figure)
//{
//    if (figure > 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine("input symbol");
//int figures = int.Parse(Console.ReadLine());
//bool check_positive = IsPositive(figures);
//Console.WriteLine(check_positive);
//// TASK 2
//2 Разработать метод Ispositive, определяющий является ли число
//положительным 
//using System.Globalization;


//Console.WriteLine("input figure");
//int n = int.Parse(Console.ReadLine());
//int factorialn = Factorial(n);
//string result = string.Format($"Факториал {n} = {factorialn}");
//Console.WriteLine(result);
////static void Factorial(int n,out int result)
////{
////    int p=1;
////    for(int i = 1; i <= n; i++)
////    {
////         p= p* i;
////    }
////    result = p;


////}
////Console.WriteLine("input figure");
////int n = int.Parse(Console.ReadLine());
////Factorial(n,out int result1);
////string result = string.Format($"Факториал {n} = {result1}");
////Console.WriteLine(result);
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
Console.WriteLine("Введите количество обьектов");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
bool ispositive_n = IsPositive(n);
Console.WriteLine(ispositive_n);
Console.WriteLine("Введите число обьектов для перестановки");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
bool ispositive_m =IsPositive(m);
Console.WriteLine(ispositive_m);
static int NumberOfPermutations(int n, int m)
{
    int factorial_n = Factorial(n);
    int d = n - m;
    int factorial_d = Factorial(d);
    return factorial_n / factorial_d;
}
int result = NumberOfPermutations(n, m);
string result1 = string.Format($"Число комбинаций  = {result}");
Console.WriteLine(result1);
