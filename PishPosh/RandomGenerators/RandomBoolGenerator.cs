using System;

namespace PishPosh
{
    public class RandomBoolGenerator : IRandomBoolGenerator
    {
        private readonly Random _random = new Random();

        public bool Next()
        {
            return _random.NextDouble() > 0.5;
        }
    }
}
