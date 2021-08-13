namespace Systeem
{
    public abstract class Type : DeelnemerInfo, IReflecteer
    {
        public static readonly char Afbakener;
        public static readonly Type[] LegeTypes;
        public static readonly DeelnemerFilter FilterAttribuut;
        public static readonly DeelnemerFilter FilterNaam;
        public static readonly DeelnemerFilter FilterNaamNegeerCasus;
        public static readonly object Ontbrekend;

        protected Type();

        public static Vastmaker StandaardVastmaker { get; }

    }
}