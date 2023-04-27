namespace WebApplication3.Models.TMS_HW
{
    
        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string CountOfPages { get; set; }
           
            public virtual Author Author { get; set; }
        }
    
}
