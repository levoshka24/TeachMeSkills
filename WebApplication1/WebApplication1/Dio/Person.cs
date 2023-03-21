namespace WebApplication1.Dio
{
    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Person(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
        }
    }
}
