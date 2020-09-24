using BO.Annot;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Extension
{
    public static class EnumExtension
    {
        public static string GetName(this Enum val)
        {
            NameByAnnotation[] attributes = (NameByAnnotation[])val
            .GetType()
            .GetField(val.ToString())
            .GetCustomAttributes(typeof(NameByAnnotation), false);
            return attributes.Length > 0 ? attributes[0].Name : string.Empty;
        }
    }
}
