using System;
using Xunit;

namespace PishPosh.Tests
{
    public class CrossRoadsTests
    {
        [Theory]
        [ClassData(typeof(SmallCrossRoadsTestData))]
        public void TestSmallCrossRoadsStrategy(IVillager villager1, IVillager villager2, bool leftIsSafe)
        {
            var strat = new Strategies(leftIsSafe);

            var ans = strat.SmallIsLeftRoadSafe(villager1, villager2);

            Assert.Equal(leftIsSafe, ans);
        }

        [Theory]
        [ClassData(typeof(LargeCrossRoadsTestData))]
        public void TestLargeCrossRoadsStrategy(IVillager villager1, IVillager villager2, IVillager villager3, bool leftIsSafe)
        {
            var strat = new Strategies(leftIsSafe);

            var ans = strat.LargeIsLeftRoadSafe(villager1, villager2, villager3);

            Assert.Equal(leftIsSafe, ans);
        }
    }
}
