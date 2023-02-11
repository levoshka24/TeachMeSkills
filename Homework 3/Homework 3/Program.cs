// TASK 2
string line = "виктор мыл пилораму";
string[] subs = line.Split(' ');
var sorted = subs.OrderBy(n => n.Length);
var shortest = sorted.FirstOrDefault();
var longest = sorted.LastOrDefault();
Console.WriteLine($"The shortest-{shortest}");
Console.WriteLine($"The longest-{longest}");
// TASK 3
//string ln= "ffffff ghtg flgkdem";
//string[] mass = line.Split(' ');
//char l = Convert.ToChar(Console.ReadLine());
//for(int i = 0; i < mass.Length; i++)
//{
//    int freq = mass.Count(f => (f == l));
//    Console.WriteLine(freq);
//}

string str = "Techie Delight";
string[] mass = str.Split(' ');
char ch = Convert.ToChar(Console.ReadLine());
int freq = str.Count(f => (f == ch));
Console.WriteLine(freq);
