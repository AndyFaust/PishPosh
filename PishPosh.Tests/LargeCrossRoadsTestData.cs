using System.Collections;
using System.Collections.Generic;

namespace PishPosh.Tests
{
    public class LargeCrossRoadsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            foreach(var language in new ILanguage[] { new PishMeansTrue(), new PoshMeansTrue() })
            {
                foreach(var leftIsSafe in new[] { true, false })
                {
                    var villagers = new IVillager [] { 
                        new TruthTeller(language),
                        new Liar(language),
                        new RandomGuy(language, new RandomBoolGenerator())
                    };

                    foreach (var villagerPerm in villagers.Permute())
                    {
                        yield return new object[] { villagerPerm[0], villagerPerm[1], villagerPerm[2], leftIsSafe };
                    }
                }
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
