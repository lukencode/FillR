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
    public class CompanyFiller : IPropertyFiller
    {
        private Random _rand;
        private static Regex _regex = new Regex(@"\b(company|companyname)\b", RegexOptions.IgnoreCase);

        public CompanyFiller(Random r)
        {
            _rand = r;
        }

        public bool ShouldFill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(string))
                return false;

            var cleaned = prop.Name.Replace("_", "");

            return _regex.IsMatch(cleaned);
        }

        public object Fill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(string))
                return false;

            return Company.Names.PickRandom();
        }
    }
}
