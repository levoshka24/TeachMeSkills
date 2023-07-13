using ConsoleApp26;
int n = Convert.ToInt32(Console.ReadLine());
Audi[] audi_mass = new Audi[n];
void Input(Audi audi)
{
    audi.Description = Console.ReadLine();
    audi.Name = Console.ReadLine();
    audi.Dviglo= int.Parse(Console.ReadLine());
}
void Input2(int kolvoelem)
{
    for(int i = 0; i < kolvoelem; i++)
    {
        Input(audi_mass[i]);
    }
}
static void FindAudi(Audi[] audi,out int count)
{
    count = 0;
    for(int i = 0; i < audi.Length; i++)
    {
        if (audi[i].Name == "Audi")
        {
            count += 1;
        }
    }
    
}
Input2(n);
FindAudi(audi_mass,out int c);
Console.WriteLine(c);
void Say<T>(T value)
{
    Console.WriteLine(value);

}
void Say2()
{
    Console.WriteLine("dd");
}
void Say2()
{
    Console.WriteLine("dd");
}
DelOper oper;
