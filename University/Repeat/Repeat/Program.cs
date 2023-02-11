//13 В некоторой стране используются денежные купюры
//достоинством в 1, 2, 4, 8, 16, 32 и 64. Дано натуральное число n. Как
//наименьшим количеством таких денежных купюр можно выплатить сумму n
//(указать количество каждой из используемых для выплаты купюр)?
//Предполагается, что имеется достаточно большое количество купюр всех
//достоинств.
//TASK 1
//int n, k;
//Console.WriteLine("Введите сумму");
//n = int.Parse(Console.ReadLine());
//k = 64;
//Console.WriteLine("Найкратчайшее количство купюр которое вам надо будет отдать");
//while (n > 0)
//{
//    if (n >= k)
//    {
//        //int z = n / k;
//        Console.WriteLine(n / k + "*" + k);
//        n = n % k;
//        k = k / 2;

//    }
//}
int q1, q2, q8, q32, q64,q16,q4;
q1 = q2 = q4 = q8 = q16 = q32 = q64 = 0;
int n = int.Parse(Console.ReadLine());
while (n > 0)
{
    q64 = n / 64;
    n = n % 64;
    q32 = n / 32;
    n = n % 32;
    q16 = n / 16;
    n = n % 16;
    q8 = n / 8;
    n = n % 8;
    q4 = n / 4;
    n = n % 4;
    q2 = n / 2;
    n = n % 2;
    q1 = n;
}
Console.WriteLine($"по 64 - {q64}");
Console.WriteLine($"по 32 - {q32}");
Console.WriteLine($"по 16 - {q16}");
Console.WriteLine($"по 8 - {q8}");
Console.WriteLine($"по 4 - {q4}");
Console.WriteLine($"по 2 - {q2}");
Console.WriteLine($"по 1 - {q1}");
///
/// 
/// 13 Дано число R и массив размера N. Найти два различных элемента
//массива, сумма которых наиболее близка к числу R, и вывести эти элементы
//в порядке возрастания их индексов.
//// TASK 2
//}
//Console.WriteLine("Input N");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] l = new int[n];
//int r, result, k, f;
//Console.WriteLine("введите R");
//r = int.Parse(Console.ReadLine());
//Console.WriteLine("-------------");
//for (int i = 0; i < l.Length; i++)
//{
//    l[i] = Convert.ToInt32(Console.ReadLine());

//}
//result = l[0] + l[1];
//k = 0;
//f = 1;

//for (int i = 0; i < l.Length; i++)// 1 element
//{
//    for (int j = 0; j < l.Length; j++)//2 element
//    {
//        if (l[i] != l[j] && (l[i] + l[j]) > result && (l[i] + l[j]) <= r)
//        {
//            result = l[i] + l[j];//запоминаем сумму
//            k = i;//запоминаем индекс 1
//            f = j;//remember 2 elemnt
//        }
//    }
//}
//Console.WriteLine("--------------------");
//if (k > f)
//{
//    Console.WriteLine(l[k] + " " + l[f]); //Если индекс i (k) больше чем j (f)  
//}
//else
//{
//    Console.WriteLine(l[k] + " " + l[f]);//Если индекс i (k)  меньше чем j (f)
//}
//13 Дан квадратный двумерный массив целых чисел.
//Выяснить: имеются ли отрицательные числа в нижнем треугольнике,
//относительно главной диагонали;
//Поменять местами элементы первой строки и первого столбца.
//Console.WriteLine("input strok");
//int strok = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("input stolbcov");
//int stolb = Convert.ToInt32(Console.ReadLine());
//Random rnd = new Random();
//int[,] l = new int[strok, stolb];
//for (int i = 0; i < strok; i++)
//{
//    for (int j = 0; j < stolb; j++)
//    {
//        l[i, j] = rnd.Next(-9, 9);
//    }
//}
//Console.WriteLine("--------------");
//for (int i = 0; i < strok; i++)
//{
//    for (int j = 0; j < stolb; j++)
//    {
//        Console.Write(l[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int n = 0;
//for (int i = 0; i < strok; i++)
//{
//    for (int j = 0; j < stolb; j++)
//    {
//        if (i == j)
//        {
//            for (int k = 1; k < strok - i; k++)
//            {
//                if (l[i, j + k] < 0)
//                {
//                    n++;
//                }
//            }
//        }
//    }
//}
//int count = 0;
//for(int i = 1; i < l.GetLength(0); i++)
//{
//    for(int j = 0; j < i; j++)
//    {
//        if (l[i, j] < 0)
//        {
//            count += 1;
//        }
//    }
//}
//var result = string.Format("Число отрицательных элементов{0}", count);
//Console.WriteLine(result);