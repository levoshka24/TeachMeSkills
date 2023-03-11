using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using HW_SERIAl;
using static HW_SERIAl.SuperHero;

using (FileStream fs = new FileStream("task4.json", FileMode.OpenOrCreate))
{
    SuperHero[]? hero_1 = JsonSerializer.Deserialize<SuperHero[]>(fs);
    
    //SuperHero.Members[]? member = JsonSerializer.Deserialize<SuperHero.Members[]>(fs);
    
    //Console.WriteLine($"{hero_1?.},{hero_1?.Active},{hero_1?.Heroname},{hero_1?.SecretBase},{hero_1?.Formed}");
}
