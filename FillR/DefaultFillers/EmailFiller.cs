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
        private Random _rand;

        public EmailFiller(Random r)
        {
            _rand = r;
        }

        public bool ShouldFill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(string))
                return false;

            return prop.Name.ToLower().Contains("email");
        }

        public object Fill(PropertyInfo prop)
        {
            var username = new UsernameFiller(_rand).Fill(prop).ToString();
            var domain = Company.Names.PickRandom(_rand) + "." + Internet.TopLevelDomains.PickRandom(_rand);

            if (_rand.Next(3) == 0)
                domain += "." + Internet.CountryDomains.PickRandom(_rand);

            return (username + "@" + domain).ToLower();
        }
    }
}
