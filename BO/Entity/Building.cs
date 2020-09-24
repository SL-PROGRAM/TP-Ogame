using BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public abstract class Building : IDbEntity, INamableEntity
    {
        private long? id;
        public long? Id { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        public uint? level { get; set; }

        public abstract uint? CellNB();

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