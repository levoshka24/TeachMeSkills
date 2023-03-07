
using System.Runtime.CompilerServices;

internal class Program
{
    delegate string DelegateOperation(string message);
    private static void Main(string[] args)
    {
        DelegateOperation anon = (string message) => message.ToLower();
        string res = anon("ROL");
        Console.WriteLine(res);
    }

    
}