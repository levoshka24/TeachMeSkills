using ConsoleApp27;
void Say()
{
    Console.WriteLine("say");
}
void Gau()
{
    Console.WriteLine("Gau");
}
Audi audi1 = new Audi();
DelOper oper;
oper = Say;
oper += Gau;
oper();
static void Input1(Audi audi)
{
    audi.Name = Console.ReadLine();
}
int n = int.Parse(Console.ReadLine());
Audi[] audi_mass = new Audi[n];
static Audi[] InputAllArray(Audi[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Input1(mass[i]);
    }
    return mass;
}
InputAllArray(audi_mass);