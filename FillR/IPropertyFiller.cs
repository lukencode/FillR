using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillR
{
    public interface IPropertyFiller<T>
    {
        bool ShouldFill(string propertyName, Type propertyType);
        T Fill(string propertyName, Type propertyType);
    }
}
