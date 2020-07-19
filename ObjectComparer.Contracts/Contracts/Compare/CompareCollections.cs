using ObjectComparer.Contracts.Interfaces;
using System.Collections;
using System.Linq;

namespace ObjectComparer.Contracts.Contracts
{
    public class CompareCollections : ICompare
    {
        public bool IsEqual(object first, object second)
        {
            var lstFirst = ((IEnumerable)first).Cast<object>().ToList();
            var lstSecond = ((IEnumerable)second).Cast<object>().ToList();
            if (lstFirst.Count != lstSecond.Count)
                return false;

            if(!lstFirst.OrderBy(x => x).SequenceEqual(lstSecond.OrderBy(x => x)))
                return false;

            return true;
        }
    }
}
