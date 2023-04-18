using ConsoleApp9;
using System.Text.Json;
using System.IO;
using static System.IO.FileStream;
Person tom = new Person("Tom",18,"khalmou" ,174);
string json = JsonSerializer.Serialize(tom);
Console.WriteLine(json);

struct Person
{
    public string Name { get; }
    public string Surname { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public Person(string name, int age,string surname,int height)
    {
        Name = name;
        Age = age;
        Surname = surname;
        Height = height;


    }
}