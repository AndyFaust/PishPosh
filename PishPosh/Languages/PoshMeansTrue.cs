namespace PishPosh
{
    public class PoshMeansTrue : ILanguage
    {
        public PishPosh Translate(bool statement)
        {
            if (statement == true)
                return PishPosh.Posh;

            else return PishPosh.Pish;
        }

        public bool Translate(PishPosh statement)
        {
            return statement == PishPosh.Posh;
        }
    }
}
