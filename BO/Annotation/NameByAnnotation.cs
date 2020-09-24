using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BO.Annot
{
    public class NameByAnnotation : Attribute
    {
        public string Name { get; set; }
    }
}
