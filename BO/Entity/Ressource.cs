using BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public class Ressource : IDbEntity
    {
        private long? id;
        private string name { get; set; }
        private int? lastQuantity { get; set; }
        private DateTime lastUpdate { get; set; }
        public long? Id { get => id; set => id = value; }

    }
}