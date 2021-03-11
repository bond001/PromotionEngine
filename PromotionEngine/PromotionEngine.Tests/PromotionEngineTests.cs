using System;
using Xunit;

namespace PromotionEngine.Tests
{
    public class PromottionEngineTests
    {
        [Fact]
        public void Should_Return_130_For_Three_Items_Of_A()
        {
            PromotionEngine promotionEngine = new PromotionEngine();
            int totalOrder = promotionEngine.ApplyPromotion(new Item[] { new Item("A", 50, 3)} );
            Assert.Equal(130, totalOrder);
        }

        [Fact]
        public void Should_Return_45_For_Two_Items_Of_B()
        {
            PromotionEngine promotionEngine = new PromotionEngine();
            int totalOrder = promotionEngine.ApplyPromotion(new Item[] { new Item("B", 30, 2) });
            Assert.Equal(45, totalOrder);
        }

        [Fact]
        public void Should_Return_100_For_One_Item_Each_Of_A_B_C()
        {
            PromotionEngine promotionEngine = new PromotionEngine();
            int totalOrder = promotionEngine.ApplyPromotion(new Item[] { new Item("A", 50, 1), new Item("B", 30, 1), new Item("C", 20, 1) });
            Assert.Equal(100, totalOrder);
        }
    }
}
