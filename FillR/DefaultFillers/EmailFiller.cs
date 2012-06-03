using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using FillR.Data;
using FillR.Extensions;

namespace FillR.DefaultFillers
{
    public class EmailFiller : IPropertyFiller
    {
        public bool ShouldFill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(string))
                return false;

            return prop.Name.ToLower().Contains("email");
        }

        public object Fill(PropertyInfo prop)
        {
            var username = new UsernameFiller().Fill(prop).ToString();
            var domain = Company.Names.PickRandom() + "." + Internet.TopLevelDomains.PickRandom();

            var rand = new Random();

            if (rand.Next(3) == 0)
                domain += "." + Internet.CountryDomains.PickRandom();

            return (username + "@" + domain).ToLower();
        }
    }
}
