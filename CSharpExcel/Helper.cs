using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExcel
{
    public static class Helper
    {
        public static void SetPropValue<TModel>(this TModel src, string propName, object val)
        {
            if (src.GetType().GetProperty(propName) != null)
            {
                src.GetType().GetProperty(propName).SetValue(src, val);
            }
        }

        public static T GetPropValue<T>(this object src, string propName)
        {
            return (T)src.GetType().GetProperty(propName).GetValue(src, null);
        }

        public static object GetPropValue(this object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
