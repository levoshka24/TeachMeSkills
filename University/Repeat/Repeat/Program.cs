int n, k;
Console.WriteLine("Введите сумму");
n = int.Parse(Console.ReadLine());
k = 64;
Console.WriteLine("Найкратчайшее количство купюр которое вам надо будет отдать");
while (n > 0)
{
    if (n >= k)
    {
        int z = n / k;
        Console.WriteLine(z + "*" + k);
        n = n % k;
        k = k / 2;

    }
    
    
        
    
}