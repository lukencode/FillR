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
        private static Regex _combinedRegex = new Regex("name|fullname|firstname|lastname|surname|middlename|maidenname", RegexOptions.IgnoreCase);
        private static Regex _fullNameRegex = new Regex("name|fullname", RegexOptions.IgnoreCase);
        private static Regex _firstNameRegex = new Regex("firstname|middlename", RegexOptions.IgnoreCase);
        private static Regex _surnameRegex = new Regex("lastname|surname|maidenname", RegexOptions.IgnoreCase);

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
                return Names.FirstNames.PickRandom();
            }
            else if (_surnameRegex.IsMatch(cleaned))
            {
                return Names.Surnames.PickRandom();
            }
            else
            {
                return Names.FirstNames.PickRandom() + " " + Names.Surnames.PickRandom();
            }
        }
    }
}
