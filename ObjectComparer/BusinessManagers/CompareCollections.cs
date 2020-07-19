using ObjectComparer.Contacts.Factory;
using ObjectComparer.Contracts.Interfaces;
using System.Collections;
using System.Linq;

namespace ObjectComparer.BusinessManagers
{
    public class CompareCollections : ICompare
    {
        public bool IsEqual(object first, object second)
        {
            var lstFirst = ((IEnumerable)first).Cast<object>().ToList();
            var lstSecond = ((IEnumerable)second).Cast<object>().ToList();
            if (lstFirst.Count != lstSecond.Count)
                return false;

            for (int iter = 0; iter < lstFirst.Count; iter++)
            {
                ICompare compare = FactoryResolver.ResolveComparer(lstFirst[iter]);
                
                if(!compare.IsEqual(lstFirst[iter], lstSecond[iter]))
                    return false;
            }
                
            //if(!lstFirst.OrderBy(x => x).SequenceEqual(lstSecond))
            //    return false;

            return true;
        }
    }
}
