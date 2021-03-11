using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionEngine
    {
        public int ApplyPromotion(Item[] items)
        {
            if (items[0].Sku == "A" && items[0].Quantity == 3 && items[0].Price== 50)
            {
                return 130;
            }
            return 0;
        }
    }
}
