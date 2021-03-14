namespace PishPosh
{
    public class RandomGuy : IVillager
    {
        private readonly ILanguage _language;
        private readonly IRandomBoolGenerator _random;

        public RandomGuy(ILanguage language, IRandomBoolGenerator random)
        {
            _language = language;
            _random = random;
        }

        public PishPosh Ask(bool question)
        {
            var ans = _random.Next();
            return _language.Translate(ans);
        }

        public PishPosh Ask(PishPosh question)
        {
            return Ask(_language.Translate(question));
        }
    }
}
