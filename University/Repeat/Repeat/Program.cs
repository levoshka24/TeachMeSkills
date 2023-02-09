// TASK 1
//int n, k;
//Console.WriteLine("Введите сумму");
//n = int.Parse(Console.ReadLine());
//k = 64;
//Console.WriteLine("Найкратчайшее количство купюр которое вам надо будет отдать");
//while (n > 0)
//{
//    if (n >= k)
//    {
//        int z = n / k;
//        Console.WriteLine(z + "*" + k);
//        n = n % k;
//        k = k / 2;

//    }                
//}
Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());
int[] l = new int[n];
int r, result, k, f;
Console.WriteLine("введите R");
r = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");
for(int i = 0; i < l.Length; i++)
{
    l[i] = Convert.ToInt32(Console.ReadLine());
    
}
result = l[0] + l[1];
k = 0;
f = 1;

for(int i = 0; i < l.Length; i++)// 1 element
{
    for (int j = 0; j < l.Length; j++)//2 element
    {
        if (l[i] != l[j] && (l[i] + l[j]) > result && (l[i] + l[j]) <= r)
        {
            result = l[i] + l[j];//запоминаем сумму
            k = i;//запоминаем индекс 1
            f = j;//remember 2 elemnt
        }
    }
}
Console.WriteLine("--------------------");
if (k > f)
{
    Console.WriteLine(l[k] + " " + l[f]); //Если индекс i (k) больше чем j (f)  
}
else
{
    Console.WriteLine(l[k] + " " + l[f]);//Если индекс i (k)  меньше чем j (f)
}
