using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP_Ogame.Data
{
    public class TP_OgameContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TP_OgameContext() : base("name=TP_OgameContext")
        {
        }

        public System.Data.Entity.DbSet<BO.Entity.SolarSystem> SolarSystems { get; set; }

        public System.Data.Entity.DbSet<BO.Entity.Ressource> Ressources { get; set; }

        public System.Data.Entity.DbSet<BO.Entity.Planet> Planets { get; set; }
    }
}
