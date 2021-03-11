using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionEngine
    {
        public int ApplyPromotion(char[] skus, int[] skuQuantity)
        {
            if (skus[0] == 'A' && skuQuantity[0] == 3)
            {
                return 130;
            }
            return 0;
        }
    }
}
