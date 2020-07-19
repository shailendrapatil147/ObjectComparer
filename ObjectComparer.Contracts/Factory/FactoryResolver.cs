
using ObjectComparer.Contracts.Contracts;
using ObjectComparer.Contracts.Interfaces;
using System.Collections;

namespace ObjectComparer.Contacts.Factory
{
    public class FactoryResolver
    {
        public static ICompare ResolveComparer(object obj)
        {
            if (obj.GetType().IsPrimitive || typeof(string).Equals(obj.GetType()))
                return new ComparePremitiveType();
            else if (obj is ICollection)
                return new CompareCollections();
            else
                return new CompareObject();
        }
    }
}
