using System.Collections;
using System.Collections.Generic;

namespace PishPosh.Tests
{
    public class SmallCrossRoadsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            foreach(var language in new ILanguage[] { new PishMeansTrue(), new PoshMeansTrue() })
            {
                foreach(var leftIsSafe in new[] { true, false })
                {
                    var villagers = new IVillager [] { 
                        new TruthTeller(language),
                        new Liar(language)
                    };

                    foreach (var villagerPerm in villagers.Permute())
                    {
                        yield return new object[] { villagerPerm[0], villagerPerm[1], leftIsSafe };
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
