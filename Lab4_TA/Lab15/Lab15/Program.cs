////task1
////Создать метод возвращающий номер первого отрицательного элемента.
////В качестве параметров метод принимает номер элемента, с которого
////начинать поиск. В main вывести все элементы, стоящие после последнего
////отрицательного элемента.
////Создать метод, возвращающий все отрицательные элементы, используя
////предыдущий метод.
////Создать метод, меняющий местами первую и вторую половины массива. 

//internal class Program
//{
//    static void Input(out double[] mass)
//    {


//        using (var sr = new StreamReader("mass.txt", System.Text.Encoding.Default))
//        {

//            int n = int.Parse(sr.ReadLine());
//            mass = new double[n];


//            while (!sr.EndOfStream)
//            {

//                for (int j = 0; j < mass.Length; j++)
//                {
//                    mass[j] = int.Parse(sr.ReadLine());
//                }
//            }

//        }


//    }
//    static void OutPut(double[] a)
//    {
//        for (int i = 0; i < a.Length; i++)
//        {
//            Console.WriteLine(a[i]);
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
//            Array.Resize(ref result, i);
//            //result[n] = arr[i];
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
//        Input(out double[] arr);
//        OutPut(arr);
//        string path = "D:\\TeachMeSkills\\Repo\\Lab4_TA\\Lab15\\Lab15\\bin\\Debug\\net6.0\\task_1_results.txt";
//        Console.WriteLine("Введите индекс с какого искать индекс первого отрицательного");
//        int index = Convert.ToInt32(Console.ReadLine());
//        int firstminindex = FirstMinEl(index, arr);
//        using (StreamWriter writer2 = new StreamWriter(path, true))
//        {
//            writer2.WriteLine($"Индекс первого отриц - {firstminindex}");
//        }


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

//            using (StreamWriter writer2 = new StreamWriter(path, true))
//            {
//                writer2.WriteLine("Все элементы после последнего отрицательного");
//                for (int x = i + 1; x < arr.Length; x++)
//                {
//                    writer2.WriteLine($"{arr[x]}" + " ");
//                }


//            }

//        }

//        SwapHalfs(arr);

//        using (StreamWriter writer = new StreamWriter(path, true))
//        {
//            writer.WriteLine("---------------------------------------------");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                writer.WriteLine(arr[i]);
//            }
//        }
//    }
//}
//1 Подсчитать среднее арифметическое ненулевых элементов,
//расположенных над побочной диагональю.
//2 Определить существуют ли в массиве строки не содержащие нулевых
//элементов
using System.IO;

static int[,] Input2()
{
    string[] lines = File.ReadAllLines(@"D:\TeachMeSkills\Repo\Lab4_TA\Lab15\Lab15\bin\Debug\net6.0\mass_task2.txt");
    int[,] num = new int[lines.Length, lines[0].Split(' ').Length];
    for (int i = 0; i < lines.Length; i++)
    {
        string[] temp = lines[i].Split(' ');
        for (int j = 0; j < temp.Length; j++)
            num[i, j] = Convert.ToInt32(temp[j]);
    }
    return num;

}
static void Output(int[,] a)
{

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write("{0}\t", a[i, j]);
        Console.WriteLine();
    }
}
static double SredneeZero(int[,] a)
{
    double count = 0;
    double count1 = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i + j < a.GetLength(0) - 1)
            {
                count += a[i, j];
                count1 += 1;
            }
        }
    }
    return count / count1;
}
static int CountOfStrok(int[,] a)
{
    int shet = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int s = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == 0)
            {
                s += 1;
            }
        }
        if (s == 0) shet++;
    }

    return shet;
}
string path = "D:\\TeachMeSkills\\Repo\\Lab4_TA\\Lab15\\Lab15\\bin\\Debug\\net6.0\\task2_res.txt";
int[,] arr = Input2();
Output(arr);
double srednee = SredneeZero(arr);
int countofstrok = CountOfStrok(arr);
using (StreamWriter writer = new StreamWriter(path, true))
{
    writer.Write($"Среднее арифмитическое чисел над побочной диагональю - {srednee}\n");
    writer.Write($"Количество не нулувых строк - {countofstrok}");
}
