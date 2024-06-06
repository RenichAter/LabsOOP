namespace WebApplication1.Models
{
    public class Writers
    {
        public int WritersId { get; set; }
        public string? Name{get;   set;}
        public ICollection<Book>? Book { get; set; }
    }
}
