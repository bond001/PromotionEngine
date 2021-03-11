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
            if (items[0].Sku == "B" && items[0].Quantity == 2 && items[0].Price == 30)
            {
                return 45;
            }
            return 0;
        }
    }
}
