using BO.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public class Planet : IDbEntity
    {
        private long? id;
        public long? Id { get => id; set => id = value; }

        private List<Ressource> ressources = new List<Ressource>();
        public virtual List<Ressource> Ressources
        {
            get { return ressources; }
            set
            {
                if (value.Count == 4)
                {
                    ressources = value;
                }
            }
        }
        [NotMapped]
        public virtual List<Building> buildings { get; set; } = new List<Building>();
        

    }
}
