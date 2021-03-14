namespace PishPosh
{
    public class Strategies
    {
        private readonly bool _leftIsSafe;

        public Strategies(bool leftIsSafe)
        {
            _leftIsSafe = leftIsSafe;
        }

        public bool LargeIsLeftRoadSafe(IVillager villager1, IVillager villager2, IVillager villager3)
        {
            var ans1 = villager1.Ask(PishPosh.Posh == villager1.Ask(villager3 is RandomGuy));

            var nextVillager = ans1 == PishPosh.Posh ? villager2 : villager3;

            var ans2 = nextVillager.Ask(PishPosh.Posh == nextVillager.Ask(_leftIsSafe));

            return ans2 == PishPosh.Posh;
        }

        public bool SmallIsLeftRoadSafe(IVillager villager1, IVillager villager2)
        {
            var ans = villager1.Ask(PishPosh.Posh == villager1.Ask(_leftIsSafe));

            return ans == PishPosh.Posh;
        }
    }
}
