////Создать метод возвращающий номер первого отрицательного элемента.
////В качестве параметров метод принимает номер элемента, с которого
////начинать поиск. В main вывести все элементы, стоящие после последнего
////отрицательного элемента.
////Создать метод, возвращающий все отрицательные элементы, используя
////предыдущий метод.
////Создать метод, меняющий местами первую и вторую половины массива. 
//internal class Program
//{
//    static double[] Input()
//    {
//        Console.WriteLine("введите размерность массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] mass = new double[n];
//        Console.WriteLine("введите сам массив");
//        for(int i = 0; i < n; i++)
//        {
//            mass[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        return mass;
//    }
//    static void OutPut(double[] a)
//    {
//        for(int i = 0; i < a.Length; i++)
//        {
//            Console.Write(a[i]+ " ");
//        }
//    }
//    static int FirstMinEl(int index, double[] arr)
//    {
        
//        for (int i = index; i < arr.Length; i++)
//        {
//            if (arr[i] < 0)
//            {
//                return i;
//            }
//        }
//        return -1;
//    }

//    static double[] AllMin(double[] arr)
//    {
//        double[] result = new double[arr.Length];
//        double[] el = { };
//        int i = 0, n = 0;
//        i = FirstMinEl(i, arr);
//        if (i == -1)
//        {
//            return el;
//        }
//        while (i != -1)
//        {
//            result[n] = arr[i];
//            i = FirstMinEl(i + 1, arr);
//            n++;
//        }
//        double[] res = new double[n];
//        for (i = 0; i < n; i++)
//        {
//            res[i] = result[i];
//        }
//        return res;
//    }

//    static void SwapHalfs(double[] arr)
//    {
//        for (int i = 0; i < arr.Length / 2; i++)
//        {
//            if (arr.Length % 2 != 0)
//            {
//                (arr[i], arr[arr.Length / 2 + i + 1]) = (arr[arr.Length / 2 + i + 1], arr[i]);
//            }
//            else
//            {
//                (arr[i], arr[arr.Length / 2 + i]) = (arr[arr.Length / 2 + i], arr[i]);
//            }
//        }
//    }

//    private static void Main(string[] args)
//    {
//        double[] arr = Input();
        
//        Console.WriteLine("Введите индекс с какого искать индекс первого отрицательного");
//        int index = Convert.ToInt32(Console.ReadLine());
//        int firstminindex = FirstMinEl(index, arr);
//        Console.WriteLine($"Индекс первого отриц - {firstminindex}");
//        double[] all = AllMin(arr);
//        if (all.Length == 0)
//        {
//            Console.WriteLine("Отрицательных элементов нет");
//        }
//        else
//        {
//            int i = FirstMinEl(0, arr);
//            for (int x = 0; x < all.Length - 1; x++)
//            {
//                i = FirstMinEl(i + 1, arr);
//            }
//            Console.WriteLine("Все элементы после последнего отрицательного:");
//            for (int x = i + 1; x < arr.Length; x++)
//            {
//                Console.Write($"{arr[x]} ");
//            }
//            Console.WriteLine();
//        }
//        SwapHalfs(arr);
//        OutPut(arr);
//    }
//}
/////Вариант 3
//static int[,] Input2()
//{
//    Console.WriteLine("Введите размерности двумерного массива: ");
//    int n = int.Parse(Console.ReadLine());
//    int m = int.Parse(Console.ReadLine());
//    int[,] a = new int[n, m];
//    for (int i = 0; i < n; i++)
//        for (int j = 0; j < m; j++)
//        {
//            Console.Write("Введите элемент {0}-ой строки {1}-го столбца:",i+1,j+1);


//            a[i, j] = int.Parse(Console.ReadLine());
//        }
//    return a;
//}
//static void Output(int[,] a) { 

// for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//            Console.Write("{0}\t", a[i, j]);
//        Console.WriteLine();
//    }
//}
//static double SredneeZero(int[,] a)
//{
//    double count = 0;
//    double count1 = 0;
//    for(int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0;j< a.GetLength(1); j++)
//        {
//            if (i + j< a.GetLength(0)-1) 
//            {
//                count+=a[i, j];
//                count1 += 1;
//            }
//        }
//    }
//    return count / count1;
//}
//static int CountOfStrok(int[,] a)
//{
//    int shet = 0;   
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        int s = 0;
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            if (a[i, j] == 0)
//            {
//                 s+= 1;
//            }
//        }
//    if (s == 0) shet++;
//    }

//    return shet;
//}
//int[,] arr = Input2();
//Output(arr);
//double srednee = SredneeZero(arr);
//Console.WriteLine($"Среднее арифмитическое чисел над побочной диагональю - {srednee}");
//int countofstrok = CountOfStrok(arr);
//Console.WriteLine($"Количество не нулувых строк - {countofstrok}");