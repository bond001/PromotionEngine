namespace PromotionEngine
{
    public class PromotionEngine
    {
        public int ApplyPromotion(Item[] items)
        {
            int totalOrder = 0;
            PromotionA promotionA = new PromotionA();
            PromotionB promotionB = new PromotionB();
            foreach (Item item in items)
            {
                if (promotionA.CheckPromotion(item))
                {
                    promotionA.CalculateTotalOrder(item);
                    continue;
                }
                if (promotionB.CheckPromotion(item))
                {
                    promotionB.CalculateTotalOrder(item);
                    continue;
                }

                totalOrder += item.Quantity * item.Price;
            }


            return totalOrder;
        }
    }
}
