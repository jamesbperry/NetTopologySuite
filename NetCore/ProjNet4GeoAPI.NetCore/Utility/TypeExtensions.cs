using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProjNet.Utility
{
    public static class TypeExtensions
    {
#if NETSTANDARD1_6
        public static bool IsAssignableFrom(this Type t, Type other)
        {
            return t.GetTypeInfo().IsAssignableFrom(other);
        }

        public static ConstructorInfo GetConstructor(this Type t, Type[] types)
        {
            return t.GetTypeInfo().GetConstructor(types);
        }
#endif
    }
}
