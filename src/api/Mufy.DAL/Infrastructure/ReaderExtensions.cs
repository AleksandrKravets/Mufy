using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Mufy.DAL.Infrastructure
{
    internal static class ReaderExtensions
    {
        public static T ReadObject<T>(this DbDataReader reader)
        {
            reader.Read();

            var instance = (T)Activator.CreateInstance(typeof(T));

            foreach (var instanceProperty in instance.GetType().GetProperties())
            {
                instanceProperty.SetValue(instance, Convert.ChangeType(reader[instanceProperty.Name], instanceProperty.PropertyType));
            }

            return instance;
        }

        public static List<T> ReadList<T>(this DbDataReader reader)
        {
            var result = new List<T>();

            while (reader.Read())
            {
                var instance = reader.ReadObject<T>();
                result.Add(instance);
            }

            return result;
        }
    }
}
