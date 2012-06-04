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
    public class DateOfBirthFiller : IPropertyFiller
    {
        private Random _rand;

        private static Regex _combinedRegex = new Regex(@"\b(dob|birthdate|dateofbirth)\b", RegexOptions.IgnoreCase);

        public DateOfBirthFiller(Random r)
        {
            _rand = r;
        }

        public bool ShouldFill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(string))
                return false;

            return _combinedRegex.IsMatch(prop.Name);
        }

        public object Fill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(DateTime))
                return false;

            return GenerateRandomDate(); //TODO: allow specification of age range and pass into the function below.
        }

        public DateTime GenerateRandomDate(DateTime? start = null, DateTime? end = null)
        {
            if (start.HasValue && end.HasValue && start.Value >= end.Value)
                throw new ArithmeticException("Start Date must be less than End Date.");

            DateTime min = start ?? DateTime.Now.AddYears(-99);
            DateTime max = end ?? DateTime.Now;

            TimeSpan timeSpan = max - min;

            byte[] bytes = new byte[8];
            _rand.NextBytes(bytes);

            long int64 = Math.Abs(BitConverter.ToInt64(bytes, 0)) % timeSpan.Ticks;

            TimeSpan newSpan = new TimeSpan(int64);

            return min + newSpan;
        }
    }
}
