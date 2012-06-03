using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using FillR.DefaultFillers;

namespace FillR
{
    public static class FillR
    {
        private static List<IPropertyFiller> _fillers = new List<IPropertyFiller> { new NameFiller(), new UsernameFiller(), new EmailFiller() };

        public static T Fill<T>(this T item)
        {
            var type = typeof(T);
            var properties = GetSettableProperties(type);

            foreach (var p in properties)
            {
                var filler = _fillers.FirstOrDefault(f => f.ShouldFill(p));

                if (filler != null)
                {
                    p.SetValue(item, filler.Fill(p), null);
                }
            }

            return item;
        }

        public static T Fill<T>() where T : new()
        {
            var item = new T();
            return item.Fill();
        }

        private static PropertyInfo[] GetSettableProperties(Type type)
        {
            var fromFields = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var list = new List<PropertyInfo>(fromFields.Length);
            list.AddRange(fromFields.Where(info => info.CanWrite));
            return list.ToArray();
        }
    }
}
