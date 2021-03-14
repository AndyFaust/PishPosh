namespace PishPosh
{
    public class PishMeansTrue : ILanguage
    {
        public PishPosh Translate(bool statement)
        {
            if (statement == true)
                return PishPosh.Pish;

            else return PishPosh.Posh;
        }

        public bool Translate(PishPosh statement)
        {
            return statement == PishPosh.Pish;
        }
    }
}
