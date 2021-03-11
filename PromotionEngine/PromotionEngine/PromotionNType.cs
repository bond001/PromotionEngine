using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionNType
    {
        public Dictionary<string, Tuple<int, int>> SkuPromotionLookup { get; set; }

        public PromotionNType()
        {
            SkuPromotionLookup = new Dictionary<string, Tuple<int, int>>();
            this.SkuPromotionLookup.Add("A", new Tuple<int, int>(3, 130));
            this.SkuPromotionLookup.Add("B", new Tuple<int, int>(2, 45));
        }
        public bool CheckPromotion(Item item)
        {

            if(SkuPromotionLookup.ContainsKey(item.Sku) && item.Quantity >= SkuPromotionLookup[item.Sku].Item1)
            {
                return true;
            }

            return false;
        }

        public int CalculateTotalOrder(Item item)
        {
            if (this.CheckPromotion(item))
            {
                Tuple<int, int> promotionVariables = SkuPromotionLookup[item.Sku];
                return promotionVariables.Item2 + ((item.Quantity - promotionVariables.Item1) * item.Price);
            }

            return 0;
        }
    }
}
