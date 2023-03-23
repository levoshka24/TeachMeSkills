namespace HW2.Models
{
    public class Production
    {
        public int Id { get; set; } 
        public string Name_Product { get; set; }
        public string Count { get; set; }
        public string Need_Count { get; set; }
        public Production(int id, string name_Product, string count, string need_Count)
        {
            Id = id;
            Name_Product = name_Product;
            Count = count;
            Need_Count = need_Count;
        }
    }
}
