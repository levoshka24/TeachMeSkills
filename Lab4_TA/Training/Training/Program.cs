using System.Text.Json;

using (FileStream fs = new("mass.json", FileMode.OpenOrCreate))
{
    int[] arr = {1,2,3,4,6,7,8,9,10};
    JsonSerializer.Serialize(fs, arr);
}