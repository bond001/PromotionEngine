using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionA
    {
        public bool CheckPromotion(Item item)
        {
            if (item.Sku == "A" && item.Quantity >= 3 && item.Price == 50)
            {
                return true;
            }

            return false;
        }

        public int CalculateTotalOrder(Item item)
        {
            return 130 + ((item.Quantity - 3) * item.Price);
        }
    }
}
