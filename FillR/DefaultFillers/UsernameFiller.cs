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
        public bool ShouldFill(System.Reflection.PropertyInfo prop)
        {
            return prop.Name.ToLower().Replace("_", "").Contains("username");
        }

        public object Fill(System.Reflection.PropertyInfo prop)
        {
            var username = "";

            var rand = new Random();
            var i = rand.Next(3);

            switch (i)
            {
                case 0:
                    username = Names.FirstNames.PickRandom();
                    break;

                case 1:
                    username = Names.Surnames.PickRandom();
                    break;

                default:
                    username = Names.FirstNames.PickRandom() + "." + Names.Surnames.PickRandom();
                    break;
            }

            return username.Replace(" ",  "").ToLower();
        }
    }
}
