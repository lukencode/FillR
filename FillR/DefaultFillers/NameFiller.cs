using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FillR.Extensions;

namespace FillR.DefaultFillers
{
    public class NameFiller : IPropertyFiller<string>
    {
        private Random _rand;

        private static Regex _combinedRegex = new Regex("name|fullname|firstname|lastname|surname|middlename|maidenname", RegexOptions.IgnoreCase);
        private static Regex _fullNameRegex = new Regex("name|fullname", RegexOptions.IgnoreCase);
        private static Regex _firstNameRegex = new Regex("firstname|middlename", RegexOptions.IgnoreCase);
        private static Regex _surnameRegex = new Regex("lastname|surname|maidenname", RegexOptions.IgnoreCase);

        private static List<string> _firstNames = new List<string> { "Luke", "John", "Mary" };
        private static List<string> _surnames = new List<string> { "Lowrey", "Smith", "Peters" };

        public NameFiller()
        {
            _rand = new Random();
        }

        public bool ShouldFill(string propertyName, Type propertyType)
        {
            if (propertyType != typeof(string))
                return false;

            var cleaned = propertyName.Replace("_", "");
            return _combinedRegex.IsMatch(cleaned);
        }

        public string Fill(string propertyName, Type propertyType)
        {
            var cleaned = propertyName.Replace("_", "");

            if (_firstNameRegex.IsMatch(cleaned))
            {
                return _firstNames.PickRandom();
            }
            else if (_surnameRegex.IsMatch(cleaned))
            {
                return _surnames.PickRandom();
            }
            else
            {
                return _firstNames.PickRandom() + " " + _surnames.PickRandom();
            }
        }
    }
}
