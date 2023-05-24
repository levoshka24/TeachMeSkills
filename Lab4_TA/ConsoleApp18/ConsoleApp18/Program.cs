using ConsoleApp18;
void Say()
{
    Console.WriteLine("hi");
}
void Mine() {
    Console.WriteLine("zib hai");

}
Delegateoper oper;
oper = Say;
oper += Mine;
Delegate oper2 = () => Console.WriteLine("fkkkkkkkk");
oper2();