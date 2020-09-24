using BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public abstract class Building : IDbEntity
    {
        private long? id;
        public string name { get; set; }
        public int? level { get; set; }
        public long? Id { get => id; set => id = value; }

        public abstract int? CellNB();

        public List<Ressource> TotalCost()
        {
            return null;
        }

        public List<Ressource> NextCost()
        {
            return null;
        }


    }
}