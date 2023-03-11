using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using TA__;


using(var fs = new FileStream("doctor_1.json", FileMode.OpenOrCreate))
{
    var doctor_1 = new Doctor("lol", 44, 34, "xerurg");

    JsonSerializer.Serialize(fs,doctor_1);
}
using (var fs = new FileStream("doctor_1.json", FileMode.OpenOrCreate))
{
    Doctor? newdoctor = JsonSerializer.Deserialize<Doctor>(fs);
    Console.WriteLine($"{newdoctor.Name}");
}
