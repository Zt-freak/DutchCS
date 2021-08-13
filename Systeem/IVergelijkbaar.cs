namespace Systeem
{
    public interface IVergelijkbaar
    {
        int VergelijkMet(object? obj);
    }

    public interface IVergelijkbaar<in T>
    {
        int VergelijkMet(T? andere);
    }
}
