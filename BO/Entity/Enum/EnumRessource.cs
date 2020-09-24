using BO.Annot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity.Enum
{
    public enum EnumRessource
    {
        [NameByAnnotation(Name = "énergie")]
        ENERGIE = 1,
        [NameByAnnotation(Name = "oxygène")]
        OXYGENE = 2,
        [NameByAnnotation(Name = "acier")]
        ACIER = 3,
        [NameByAnnotation(Name = "uranium")]
        URANIUM = 4
    };
}
