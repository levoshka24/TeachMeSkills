using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using HW_SERIAl;
using static HW_SERIAl.SuperHero;


    using (var fs = new FileStream("task5.json", FileMode.Open))
    {
        var superHeroSquad = JsonSerializer.Deserialize<Squad>(fs);
        Console.WriteLine($"Имя отряда: {superHeroSquad.squadName} Город действия: {superHeroSquad.homeTown} Дата основания: {superHeroSquad.formed} Секретная база: {superHeroSquad.secretBase} Активность: {superHeroSquad.active}");
        Console.WriteLine("Члены отряда:");
        superHeroSquad.ShowMemebrs();

    }

