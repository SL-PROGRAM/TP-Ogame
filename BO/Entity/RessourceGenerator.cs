using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public abstract class RessourceGenerator : Building
    {
        public virtual List<Ressource> RessourceBySecond()
        {
            return null;
        }
    }
}