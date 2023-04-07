namespace WebApplication1.Models
{
    public class Persons
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public Persons(int id, string name, string surname, string age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
