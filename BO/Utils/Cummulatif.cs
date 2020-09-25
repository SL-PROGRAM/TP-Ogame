using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Utils
{
    public static class Cummulatif
    {
        public static Double Calculate(Func<uint, double> func, uint level)
        {
            double cumul = 0;
            for (int li = int.Parse(level.ToString()); li >= 0; li--)
            {
                cumul += func.Invoke(uint.Parse(li.ToString()));
            }
            return cumul;
        }
    }
}
