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
        private readonly Random _rand;

        private static readonly Regex CombinedRegex = new Regex(@"\b(dob|birthdate|dateofbirth)\b", RegexOptions.IgnoreCase);

        public DateOfBirthFiller(Random r)
        {
            _rand = r;
        }

        public bool ShouldFill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(DateTime?))
                return false;

            return CombinedRegex.IsMatch(prop.Name);
        }

        public object Fill(PropertyInfo prop)
        {
            if (prop.PropertyType != typeof(DateTime?))
                return false;

            return GenerateRandomDate(); //TODO: allow specification of age range and pass into the function below.
        }

        public DateTime GenerateRandomDate(DateTime? start = null, DateTime? end = null)
        {
            if (start.HasValue && end.HasValue && start.Value >= end.Value)
                throw new ArithmeticException("Start Date must be less than End Date.");

            var min = start ?? DateTime.Now.AddYears(-99);
            var max = end ?? DateTime.Now;

            var timeSpan = max - min;

            var bytes = new byte[8];
            _rand.NextBytes(bytes);

            var int64 = Math.Abs(BitConverter.ToInt64(bytes, 0)) % timeSpan.Ticks;

            var newSpan = new TimeSpan(int64);

            return min + newSpan;
        }
    }
}
