﻿//// TASK 1
//for(int i = 1; i <= 99; i++)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}
//// TASK 2
//int x = 6;
//while (x > 1)
//{
//    x--;
//    Console.WriteLine(x);
//}
// TASK 3
//Console.WriteLine("введите число");
//int value = int.Parse(Console.ReadLine());
//int sum = 0;
//for(int i = 1; i <= value; i++)
//{
//    sum += i;
//}
//Console.WriteLine($"Сумма чисел от 1 до {value} = {sum}");
// TASK 4
//int x = 14;
//while (x < 98)
//{
//    x += 7;
//    Console.WriteLine(x);
//}
// TASK 5
//for(int i = 0; i >= -45; i -= 5)
//{
//    Console.WriteLine(i);
//}
// TASK 6
//for(int i = 10; i <= 20; i++)
//{
//    Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i,2)}");
//}
// TASK 0
//Console.WriteLine("Введите размерность массива");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("введите члены массива");
//int[] arr = new int[n];
//for(int i = 0; i < n; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());

//}
//Console.WriteLine("введите число для проверки в массиве");
//int val = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = 0; i < n; i++)
//{
//    count += 1;

//    if (arr[i] == val)
//    {
//        Console.WriteLine("число входит в массив");
//    }
//    else
//    {
//        Console.WriteLine("не входит");
//    }

//}
//Console.WriteLine("---------------------");
// TASK 1
//using System;
//int[] l = new int[8] { 1, 2, 3, 4, 5, 6, 4, 2 };
//Console.WriteLine("введите число которое нужно удалить");
//int n = int.Parse(Console.ReadLine());
//l = l.Where(e => e != n).ToArray();
//Console.WriteLine(String.Join(",", l));
// TASK 2
//Console.WriteLine("Введите размерность массива");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("---------------------------");
//int[] arr2 = new int[n];
//Random rnd = new Random();
//int max = 0;
//double count = 0;
//for(int i = 0; i < n; i++)
//{
//    arr2[i] = rnd.Next(40);
//    Console.WriteLine(arr2[i]);
//    if (arr2[i] > max)
//    {
//        max=arr2[i];
//    }
//    count += arr2[i];
//}
//int c = arr2.Min();
//double d = count / arr2.Length;
//Console.WriteLine($"Макисмально число: {max}");
//Console.WriteLine($"Минимально число: {c}");
//Console.WriteLine($"Среднее чисел массива: {d}");
//TASK 3
//Console.WriteLine("Введите размерность  1 массива");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("---------------------------");
//int[] arr1 = new int[n];
//Random rnd1 = new Random();
//double count1 = 0;
//for(int i = 0; i < n; i++)
//{
//    arr1[i] = rnd1.Next(1,40);
//    Console.WriteLine(arr1[i]);
//    count1 += arr1[i];
//}
//double mid1 = count1 / arr1.Length;
//Console.WriteLine($"Среднее арифм эл 1 массива: {mid1}");
//Console.WriteLine("Введите размерность  2 массива");
//int n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("---------------------------");
//double count2 = 0;
//int[] arr2 = new int[n2];
//Random rnd2 = new Random();
//for (int i = 0; i < n; i++)
//{
//    arr2[i] = rnd2.Next(1, 40);
//    Console.WriteLine(arr2[i]);
//    count2+=arr2[i];
//}
//double mid2 = count2 / arr2.Length;
//Console.WriteLine($"Среднее арифм эл 1 массива: {mid2}");
//if (mid1 == mid2)
//{
//    Console.WriteLine("среднии равны");
//}
//if(mid1 > mid2)
//{
//    Console.WriteLine("среднее 1 больше среднего 2");
//}
//else
//{
//    Console.WriteLine("среднее 2 больше среднего 1");
//}
// DOP TASK
// TASK 1
//int first = 0, second = 1, third = 0;
//Console.Write("Enter a number : ");
//var n = Convert.ToInt32(Console.ReadLine());
//Console.Write("First {0} Fibonacci numbers {1} {2} ", n, first, second);

//for (int i = 3; i <= n; i++)
//{
//    third = first + second;
//    Console.Write("{0} ", third);
//    first = second;
//    second = third;
//}
// TASK 2
//Console.WriteLine("Введите сумму вклада");
//decimal money = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Введите период");
//int period = int.Parse(Console.ReadLine());
//for(int i = 0; i < period; i++)
//{
//    money += money * 0.07M;
//}
//Console.WriteLine($"по итогу вы получите {money}");
// TASK 4
//int n;
//do
//{
//    Console.WriteLine("Введите ");
//    Int32.TryParse(Console.ReadLine(), out n);
//} while (n<5|| n==10);
//int[] l = new int[n];

//Console.WriteLine("--------------");
//for (int i = 0; i < n; i++)
//{
//    l[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("-----------------");
//int[] l1 = Array.FindAll(l, elements => elements % 2 == 0);
//foreach(var c in l1)
//{
//    Console.WriteLine(c);
//}
// TASK 5
Console.WriteLine("введите размерность массива");
int n = int.Parse(Console.ReadLine());
int[] l = new int[n];

Console.WriteLine("--------------");
for (int i = 0; i < n; i++)
{
    l[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("-----------------");
for (int i = 0; i <= n; i++)
{
    if(i%2 != 0)
    {
        l[i] = 0;
    }
    Console.WriteLine(l[i]);
}
// TASK 6
//string[] l = new string[5] { "kate", "max", "mike", "anton", "viktor" };
//Array.Sort(l);
//foreach(var c in l)
//{
//    Console.WriteLine(c);
//}
// TASK 7
//Console.WriteLine("введите размерность массива");
//int n = int.Parse(Console.ReadLine());
//int[] l = new int[n];

//Console.WriteLine("--------------");
//for (int i = 0; i < n; i++)
//{
//    l[i] = int.Parse(Console.ReadLine());
//}
//for(int i = 1; i < n; i++)
//{
//    for(int j = 0; j < n-i; j++)
//    {
//        if (l[j+1] > l[j])
//        {
//            int t = l[j];
//            l[j] = l[j + 1];
//            l[j + 1] = t;
//        }
//    }
//}
//Console.WriteLine("------------");
//for(int i = 0; i < n; i++)
//{
//    Console.WriteLine(l[i]);
//}