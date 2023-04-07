using System.Diagnostics;

//int i = 0;
//int n;
//int e;
//int j;
//int count = 0;
//var time = new Stopwatch();
//const int m = 100;
//int[] a = new int[m];
//int[] b = new int[m];
//time.Start();
//Console.Write("size :\n");
//n = int.Parse(Console.ReadLine());
//Console.Write("array :\n");
//count += 2;
//for (i = 0; i < n; i++)
//{
//    count += 2;
//    a[i] = int.Parse(Console.ReadLine());
//    count += 3;
//}
//Console.Write("included : \n");
//e = int.Parse(Console.ReadLine());
//i = 0;
//while ((i < n) && (a[i] < e))
//{
//    count += 4;
//    i++;
//    count++; ;
//}
//count += 2;
//for (j = 0; j < i; j++)
//{
//    count += 2;
//    b[j] = a[j];
//    count += 3;
//}
//b[j] = e;
//count += 2;
//count += 3;
//for (j++; j < n + 1; j++)
//{
//    count += 3;
//    b[j] = a[j - 1];
//    count += 4;
//}
//n++;
//count++;
//Console.Write("new array:\n");
//count += 2;
//for (i = 0; i < n; i++)
//{
//    count += 2;
//    Console.Write(b[i]);
//    Console.Write(" ");
//}
//time.Stop();
//Console.WriteLine($"Потраченное время - {time.Elapsed}");
//Console.WriteLine($"Трудоемкость - {count}");
//Console.ReadKey();
// TASK 5


var time2 = new Stopwatch();
time2.Start();
int trud = 0;
Console.WriteLine("Введите количество цифр");
Random rnd = new Random();
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив изначальный");
int[] arr = new int[n2];
trud += 2;
for (int j = 0; j < n2; j++)
{
    trud += 2;
    arr[j] = rnd.Next(0, 7);
    trud += 3;
    Console.Write(arr[j] + " ");
}
Array.Sort(arr);//сортируем массив
int[] distinctArr = arr.Distinct().ToArray();//удаляем дубликаты
Console.WriteLine();
Console.WriteLine("Массив конечный");
foreach (int num in distinctArr)
{

    Console.Write(num + " ");
}
Console.WriteLine();
Console.WriteLine("Трудоемкость кода=" + trud);
time2.Stop();
Console.WriteLine($"Time spent:{time2.Elapsed}");