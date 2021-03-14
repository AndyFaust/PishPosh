namespace PishPosh
{
    public interface ILanguage
    {
        PishPosh Translate(bool statement);
        bool Translate(PishPosh statement);
    }
}
