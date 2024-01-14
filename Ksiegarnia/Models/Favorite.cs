using System.ComponentModel.DataAnnotations.Schema;

namespace Ksiegarnia.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public List<Book> Books { get; set; } // Lista ulubionych książek
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
