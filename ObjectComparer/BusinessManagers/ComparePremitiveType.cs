using ObjectComparer.Contracts.Interfaces;

namespace ObjectComparer.BusinessManagers

{
    public class ComparePremitiveType : ICompare
    {
        public bool IsEqual(object first, object second)
        {
            return first.Equals(second);
        }
    }
}
