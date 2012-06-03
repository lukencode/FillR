using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FillR.Data;
using FillR.Extensions;

namespace FillR.DefaultFillers
{
    public class UsernameFiller : IPropertyFiller
    {
        private Random _rand;

        public UsernameFiller(Random r)
        {
            _rand = r;
        }

        public bool ShouldFill(System.Reflection.PropertyInfo prop)
        {
            return prop.Name.ToLower().Replace("_", "").Contains("username");
        }

        public object Fill(System.Reflection.PropertyInfo prop)
        {
            var username = "";

            var i = _rand.Next(3);

            switch (i)
            {
                case 0:
                    username = Names.FirstNames.PickRandom(_rand);
                    break;

                case 1:
                    username = Names.Surnames.PickRandom(_rand);
                    break;

                default:
                    username = Names.FirstNames.PickRandom(_rand) + "." + Names.Surnames.PickRandom(_rand);
                    break;
            }

            return username.Replace(" ",  "").ToLower();
        }
    }
}
