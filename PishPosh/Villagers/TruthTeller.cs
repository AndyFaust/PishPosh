namespace PishPosh
{
    public class TruthTeller : IVillager
    {
        private readonly ILanguage _language;

        public TruthTeller(ILanguage language)
        {
            _language = language;
        }

        public PishPosh Ask(bool question)
        {
            bool answer = question;
            return _language.Translate(answer);
        }

        public PishPosh Ask(PishPosh question)
        {
            return Ask(_language.Translate(question));
        }
    }
}
