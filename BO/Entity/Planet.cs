using BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public class Planet : IDbEntity
    {
        private long? id;
        private List<Ressource> ressources;
        public List<Building> buildings { get; set; }
        public List<Ressource> Ressources
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
        public long? Id { get => id; set => id = value; }

    }
}
