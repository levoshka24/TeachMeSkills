// TASK 1
//static bool IsSimetric(string s)
//{
//    char[] arr = s.ToCharArray();
//    Array.Reverse(arr);
//    string s2 = new string(arr);
//    if (s.Equals(s2))
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine("введите строку");
//string s = Console.ReadLine();
//bool res = IsSimetric(s);
//if (res)
//{
//    Console.WriteLine("строка симметричная") ; 
//}
//else
//{
//    Console.WriteLine("строка не симметрична");
//}
//TASK 1.0
//using System.Text;
//Console.WriteLine("input strkou");
//string str = Console.ReadLine();
//char[] arr = str.ToCharArray();
//Array.Reverse(arr);
//string s2 = new string(arr);
//string stroka = null;
//StringBuilder sb = new StringBuilder(stroka);
//sb.Append(s2);
//sb.ToString();
//if (sb.Equals(str))
//{
//    Console.WriteLine("symmetric");
//}
//else
//{
//    Console.WriteLine("no symmetric");

//}

//TASK 2
//using System.Text.RegularExpressions;
//Console.WriteLine("input stroku");
//string s = Console.ReadLine();
// заменяет любую строку на пробел тем самым новая строка и выводим длинну получаю кол-во цифр в строке
//string digits = Regex.Replace(s, @"\D", "");
//Console.WriteLine("Количество цифр:");
//Console.WriteLine(digits.Length);
// TASK 2.0
//Console.WriteLine("input stroku");
//string s = Console.ReadLine();
//char[] arr = s.ToCharArray();
//char[] resfind = Array.FindAll(arr, el => char.IsDigit(el));
//Console.WriteLine(resfind.Length);

////TASK3
//Console.WriteLine("Введите строку: ");
//string s;
//s = Console.ReadLine();

//string[] parts = s.Split();
//int min = 1000;
//int x = 0;
//for (int i = 0; i < parts.Length; i++)
//{
//    if (parts[i].Length <= min)
//    {
//        min = parts[i].Length;
//        x = i;
//    }
//}
//Console.WriteLine("Самое короткое слово: " + parts[x]);
// TASK 4
//static string ReverseWord(string s)
//{
//    char[] arr = s.ToCharArray();
//    Array.Reverse(arr);
//    string s2 = new string(arr);
//    return s2;
//}
//Console.WriteLine("введите строку");
//var str = Console.ReadLine();
//var arr = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
//string s;
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    s = ReverseWord(arr[i]);
//    Console.Write(s + " ");
//}
//Console.ReadLine();
