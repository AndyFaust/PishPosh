namespace PishPosh
{
    public class Liar : IVillager
    {
        private readonly ILanguage _language;

        public Liar(ILanguage language)
        {
            _language = language;
        }

        public PishPosh Ask(bool question)
        {
            var answer = !question;
            return _language.Translate(answer);
        }

        public PishPosh Ask(PishPosh question)
        {
            return Ask(_language.Translate(question));
        }
    }
}
