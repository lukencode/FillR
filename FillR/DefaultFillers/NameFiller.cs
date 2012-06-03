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
    public class NameFiller : IPropertyFiller
    {
        private Random _rand;

        private static Regex _combinedRegex = new Regex(@"\b(name|fullname|firstname|lastname|surname|middlename|maidenname)\b", RegexOptions.IgnoreCase);
        private static Regex _fullNameRegex = new Regex(@"\b(name|fullname)\b", RegexOptions.IgnoreCase);
        private static Regex _firstNameRegex = new Regex(@"\b(firstname|middlename)\b", RegexOptions.IgnoreCase);
        private static Regex _surnameRegex = new Regex(@"\b(lastname|surname|maidenname)\b", RegexOptions.IgnoreCase);

        public NameFiller(Random r)
        {
            _rand = r;
        }

        public bool ShouldFill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(string))
                return false;

            var cleaned = prop.Name.Replace("_", "");
            return _combinedRegex.IsMatch(cleaned);
        }

        public object Fill(PropertyInfo prop)
        {
            var cleaned = prop.Name.Replace("_", "");

            if (_firstNameRegex.IsMatch(cleaned))
            {
                return Names.FirstNames.PickRandom(_rand);
            }
            else if (_surnameRegex.IsMatch(cleaned))
            {
                return Names.Surnames.PickRandom(_rand);
            }
            else
            {
                return Names.FirstNames.PickRandom(_rand) + " " + Names.Surnames.PickRandom(_rand);
            }
        }
    }
}
