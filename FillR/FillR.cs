using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using FillR.DefaultFillers;

namespace FillR
{
    public static class FillR
    {
        public static T Fill<T>(this T item)
        {
            var type = typeof(T);
            var properties = GetSettableProperties(type);
            var fillers = GetDefaultFillers(new Random());

            foreach (var p in properties)
            {
                var filler = fillers.FirstOrDefault(f => f.ShouldFill(p));

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

        private static List<IPropertyFiller> GetDefaultFillers(Random r)
        {
            var list = new List<IPropertyFiller>()
            {
                new NameFiller(r), 
                new UsernameFiller(r), 
                new EmailFiller(r)
            };

            return list;
        }
    }
}
