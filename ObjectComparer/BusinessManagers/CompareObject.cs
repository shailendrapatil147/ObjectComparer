using ObjectComparer.Contacts.Factory;
using ObjectComparer.Contracts.Interfaces;
using System;

namespace ObjectComparer.BusinessManagers
{
    public class CompareObject : ICompare
    {
        public bool IsEqual(object first, object second)
        {
            Type type = first.GetType();

            foreach (System.Reflection.PropertyInfo property in type.GetProperties())
            {
                object Object1Value = null;
                object Object2Value = null;

                if (type.GetProperty(property.Name).GetValue(first, null) != null)
                    Object1Value = type.GetProperty(property.Name).GetValue(first, null);

                if (type.GetProperty(property.Name).GetValue(second, null) != null)
                    Object2Value = type.GetProperty(property.Name).GetValue(second, null);

                ICompare compare = FactoryResolver.ResolveComparer(Object1Value);

                if (!compare.IsEqual(Object1Value, Object2Value))
                    return false;
            }
            return true;
        }
    }
}
