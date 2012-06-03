using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FillR
{
    public interface IPropertyFiller
    {
        bool ShouldFill(PropertyInfo prop);
        object Fill(PropertyInfo prop);
    }
}
