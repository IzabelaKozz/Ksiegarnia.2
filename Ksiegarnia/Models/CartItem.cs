namespace Ksiegarnia.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}
