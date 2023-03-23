namespace WebApplication4.Models
{
    public class ProductClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public ProductClass(int id, string name, string count, string country, string category)
        {
            Id = id;
            Name = name;
            Count = count;
            Country = country;
            Category = category;
        }
    }
}
