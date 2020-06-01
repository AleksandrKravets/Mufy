using System;
using System.Linq;
using System.Reflection;

namespace Mufy.DAL.Infrastructure
{
    public static class Reflector
    {
        public static FieldInfo[] GetFields(object obj)
        {
            return obj
                .GetType()
                .GetFields(
                    BindingFlags.Public |
                    BindingFlags.DeclaredOnly |
                    BindingFlags.SetField |
                    BindingFlags.GetField |
                    BindingFlags.Instance);
        }

        public static void SetFieldValue(object obj, string fieldName, object value)
        {
            obj.GetType().GetField(fieldName).SetValue(obj, value);
        }

        public static FieldInfo[] GetFieldsWithAttribute(object obj, Type parameterAttributeType)
        {
            var result = GetFields(obj)
                .Where(p => p.CustomAttributes.Any(a => a.AttributeType == parameterAttributeType))
                .ToArray();

            return result;
        }
    }
}
