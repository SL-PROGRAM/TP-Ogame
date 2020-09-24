using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Interface
{
    public interface IDbEntity
    {
        [Key] 
        [Unsigned]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        long? Id { get; set; }
  

    }
}
