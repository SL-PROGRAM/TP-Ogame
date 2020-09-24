using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Interface
{
    public interface INamableEntity
    {
        [StringLength(20, ErrorMessage = "Le nom doit etre entre 5 et 20 caractères", MinimumLength = 5)]
        string Name { get; set; }
    }
}
