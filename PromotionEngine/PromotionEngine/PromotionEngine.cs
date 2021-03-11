namespace PromotionEngine
{
    public class PromotionEngine
    {
        public int ApplyPromotion(Item[] items)
        {
            int totalOrder = 0;
            PromotionNType promotionA = new PromotionNType();
            foreach (Item item in items)
            {
                if (promotionA.CheckPromotion(item))
                {
                    totalOrder += promotionA.CalculateTotalOrder(item);
                    continue;
                }
                
                totalOrder += item.Quantity * item.Price;
            }


            return totalOrder;
        }
    }
}
