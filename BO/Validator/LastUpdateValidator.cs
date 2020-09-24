using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Validator
{
    public class LastUpdateValidator : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "La date doit etre dans le passé";
        }

        public override bool IsValid(object value)
        {
            bool result = false;
            DateTime lastUpdate = DateTime.Parse(value.ToString());
            if(DateTime.Compare(lastUpdate, DateTime.Now) < 0)
            {
                result = true;
            }

            return result;
        }
    }
}
