using Microsoft.AspNetCore.Identity;

namespace Ksiegarnia.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public List<Book> Books { get; set; } // Lista książek w koszyku
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal GetTotal()
        {
            return Items.Sum(item => item.Quantity * item.Price);
        }
        public virtual IdentityUser? User { get; set; }
    }
}
