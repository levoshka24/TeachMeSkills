//TASK1
//3 Для заданной строки определить все входящие в неё символы. Например:
//строка «abccbbbabba» состоит из символов «a»,»b» и «с».
//Console.WriteLine("Введите вашу строку");
//string line = Console.ReadLine();
//int count = 0;
//for(int i = 0; i < line.Length; i++)
//{
//    count += 1;
//    Console.WriteLine($"{count}.{line[i]}");
//}
//TASK 2


Console.WriteLine("введите символ");
char symbol = char.Parse(Console.ReadLine());
var res = symbol - 1;
var res1 = symbol + 1;
char symbolplusone = Convert.ToChar(res);
char symbolminusone = Convert.ToChar(res1);
Console.WriteLine($"Символ после - { symbolplusone}");
Console.WriteLine($"Символ перед - { symbolminusone}");

//var res = char.GetNumericValue(symbol);
//Console.WriteLine(res);

//Console.WriteLine(symbol + 1);
//3 Вывести только те слова сообщения, которые содержат хотя бы одну
//цифру.
//Console.WriteLine("изложите мысль");
//string line = Console.ReadLine();
//string[] subs = line.Split();

//for(int i = 0; i < subs.Length; i++)
//{
//    int count = subs[i].Where(x =>char.IsDigit(x)).Count();
//    if (count.Equals(1))
//    {
//        Console.WriteLine(subs[i]);
//    }
//}
// TASK 4
//3 Дана строка, содержащая, по крайней мере, один символ пробела.
//Вывести подстроку, расположенную между первым и вторым пробелом
//исходной строки. Если строка содержит только один пробел, то вывести пустую
//строку. 

//Console.WriteLine("input something");
//string line = Console.ReadLine();

//int p1, p2;
//for (int i = 0; i < line.Length; i++)
//{
//    int index = 0;
//    if (line[i] == ' ')
//    {
//        index = i;
//        break;
//    }
//}