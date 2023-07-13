using ConsoleApp20;
void Print()
{
    Console.WriteLine("zib hai");
}
void Gau()
{
    Console.Write("gau");
}
Delegoper oper = Print;
oper += Gau;
oper();
