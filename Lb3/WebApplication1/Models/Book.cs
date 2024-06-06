using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace WebApplication1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int WritersId { get; set; }
        [ForeignKey("WritersId")]

        public Writers? Writers { get; set; }
        public ICollection<BookGenre>?  BookGenres { get; set; }


    }
}
