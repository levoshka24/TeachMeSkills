using ConsoleApp29;
void Say<T>(T value)
{
    Console.WriteLine(value);
}
void Say2(string mess)
{
    Console.WriteLine(mess);
}
void Say3(string mess)
{
    Console.WriteLine(mess);
}
DelOper oper;
oper = Say2;
oper += Say3;
oper("sosi");
void Input_Example(Audi audi)
{
    audi.Engine = int.Parse(Console.ReadLine());
    audi.Description = Console.ReadLine();
}
void Input_Arr(Audi[] arr)
{
    for(int i =0; i < arr.Length; i++){


}

}
