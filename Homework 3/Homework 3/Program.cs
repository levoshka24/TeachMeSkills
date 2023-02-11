// TASK 2
//string line = "виктор мыл пилораму";
//string[] subs = line.Split(' ');
//var sorted = subs.OrderBy(n => n.Length);
//var shortest = sorted.FirstOrDefault();
//var longest = sorted.LastOrDefault();
//Console.WriteLine($"The shortest-{shortest}");
//Console.WriteLine($"The longest-{longest}");
// TASK 3
//string str = "Techie Delight";
//string[] mass = str.Split(' ');
//char ch = Convert.ToChar(Console.ReadLine());
//int freq = str.Count(f => (f == ch));
// TASK 4
//string original = Console.ReadLine();
//var reversed = new string(original.Reverse().ToArray());
//Console.WriteLine(reversed);
//var result = original.Equals(reversed);
//if (result)
//{
//    Console.WriteLine("палиндром");
//}
//else
//{
//    Console.WriteLine("не палиндром");
//}
//Console.WriteLine(freq);
// TASK 5
//string name = Console.ReadLine();
//string result = string.Join("", name.Select(x => new string(x, 2)));
//Console.WriteLine(result);