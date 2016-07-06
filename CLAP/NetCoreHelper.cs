using System;
using System.Collections.Generic;
#if !FW2
using System.Linq;
#endif
using System.Text;
using System.Reflection;

namespace CLAP
{
#if !NETCORE
    internal static class NetCoreHelper
    {
        internal static Type GetTypeInfo(this Type type)
        {
            return type;
        }

        internal static T GetCustomAttribute<T>(this MethodInfo method) where T : Attribute
        {
            var att = Attribute.GetCustomAttribute(method, typeof(T));
            return (T)att;
        }

        internal static T GetCustomAttribute<T>(this Type type) where T : Attribute
        {
            var att = Attribute.GetCustomAttribute(type, typeof(T));
            return (T)att;
        }

        internal static T GetCustomAttribute<T>(this ParameterInfo parameter) where T : Attribute
        {
            var att = Attribute.GetCustomAttribute(parameter, typeof(T));
            return (T)att;
        }

        internal static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo parameter) where T : Attribute
        {
            var atts = Attribute.GetCustomAttributes(parameter, typeof(T)).Cast<T>();
            return atts;
        }

        internal static IEnumerable<T> GetCustomAttributes<T>(this PropertyInfo property) where T : Attribute
        {
            var atts = Attribute.GetCustomAttributes(property, typeof(T)).Cast<T>();
            return atts;
        }

        internal static IEnumerable<T> GetCustomAttributes<T>(this Type type) where T : Attribute
        {
            var atts = Attribute.GetCustomAttributes(type, typeof(T)).Cast<T>();

            return atts;
        }

        internal static bool IsDefined(this MethodInfo method, Type type)
        {
            return Attribute.IsDefined(method, type);
        }

        internal static bool IsDefined(this Type type1, Type type2)
        {
            return Attribute.IsDefined(type2, type1);
        }

        internal static bool IsDefined(this ParameterInfo parameter, Type type)
        {
            return Attribute.IsDefined(parameter, type);
        }
    }
#endif
}
