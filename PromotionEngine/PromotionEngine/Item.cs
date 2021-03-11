
namespace PromotionEngine
{
    public class Item
    {
        public string Sku { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Item(string sku, int price, int quantity)
        {
            this.Sku = sku;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
