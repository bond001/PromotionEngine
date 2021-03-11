namespace PromotionEngine
{
    public class PromotionEngine
    {
        public int ApplyPromotion(Item[] items)
        {
            int totalOrder = 0;
            foreach (Item item in items)
            {
                if (item.Sku == "A" && item.Quantity >= 3 && item.Price == 50)
                {
                    totalOrder += 130 + ((item.Quantity - 3) * item.Price);
                }
                
                if (item.Sku == "B" && item.Quantity >= 2 && item.Price == 30)
                {
                    totalOrder += 45 + ((item.Quantity - 2) * item.Price);
                }

                return totalOrder;
            }
            
            return 0;
        }
    }
}
