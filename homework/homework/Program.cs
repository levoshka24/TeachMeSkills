// TASK 1
//static void IsPositive(int figure)
//{
//    if (figure > 0)
//    {
//        Console.WriteLine("положительное");
//    }
//    else
//    {
//        Console.WriteLine("отрицательное");
//    }
//}
//Console.WriteLine("input symbol");
//int figures = int.Parse(Console.ReadLine());
//IsPositive(figures);
// TASK 2
using System.Globalization;

//static int Factorial(int n)
//{
//    if (n == 1) return 1;

//    return n * Factorial(n - 1);
//}
//Console.WriteLine("input figure");
//int n = int.Parse(Console.ReadLine());
//int factorialn = Factorial(n);
//string result = string.Format($"Факториал {n} = {factorialn}");
//Console.WriteLine(result);
//static void Factorial(int n,out int result)
//{
//    int p=1;
//    for(int i = 1; i <= n; i++)
//    {
//         p= p* i;
//    }
//    result = p;


//}
//Console.WriteLine("input figure");
//int n = int.Parse(Console.ReadLine());
//Factorial(n,out int result1);
//string result = string.Format($"Факториал {n} = {result1}");
//Console.WriteLine(result);
// TASK 3
static void IsPositive(int figure)
{
    if (figure > 0)
    {
        Console.WriteLine("Число положительное");
    }
    else
    {
        Console.WriteLine("Числоотрицательное");
    }
}
Console.WriteLine("Введите количество обьектов");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
IsPositive(n);
Console.WriteLine("------------------");
Console.WriteLine("Введите число обьектов для перестановки");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");
IsPositive(m);
static int NumberOfPermutations(int n, int m)
{
    int factorialn = 1;
    for (int i = 1; i <= n; i++)
    {
        
        factorialn *= i;
    }
    
    int factorialnm = 1;
    int d = n - m;
    for (int i = 1; i <= d; i++)
    {
        
        factorialnm *= i;
    }
     return factorialn / factorialnm;
    
    

}
int result = NumberOfPermutations(n, m);
string result1 = string.Format($"Число комбинаций  = {result}");
Console.WriteLine(result1);