using ObjectComparer.Contacts.Factory;
using ObjectComparer.Contracts.Interfaces;

namespace ObjectComparer
{
    public static class Comparer
    {
        public static bool AreSimilar<T>(T first, T second)
        {
            if (first == null || second == null)
            {
                return true;
            }

            ICompare compare = FactoryResolver.ResolveComparer(first);
            return compare.IsEqual(first, second);
        }
    }
}
