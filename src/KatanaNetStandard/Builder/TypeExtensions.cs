namespace Microsoft.Owin.Builder
{
    using System;
    using System.Linq;
    using System.Reflection;

    internal static class TypeExtensions
    {
        internal static bool IsInstanceOfType(this Type type, object obj)
        {
            return obj != null && type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo());
        }

        internal static ConstructorInfo[] GetConstructors(this Type type)
        {
            return type.GetTypeInfo().DeclaredConstructors.ToArray();
        }

        internal static MethodInfo[] GetMethods(this Type type)
        {
            return type.GetTypeInfo().DeclaredMethods.ToArray();
        }

        public static MethodInfo GetMethod(this Type type, string name)
        {
            return Enumerable.FirstOrDefault<MethodInfo>(GetMethods(type), m => m.Name == name);
        }

        public static bool IsAssignableFrom(this Type type, Type otherType)
        {
            return type.GetTypeInfo().IsAssignableFrom(otherType.GetTypeInfo());
        }
    }
}