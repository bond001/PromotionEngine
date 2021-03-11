using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionB
    {
        public bool CheckPromotion(Item item)
        {
            if (item.Sku == "B" && item.Quantity >= 2 && item.Price == 30)
            {
                return true;
            }

            return false;
        }

        public int CalculateTotalOrder(Item item)
        {
            return 45 + ((item.Quantity - 2) * item.Price);
        }
    }
}
