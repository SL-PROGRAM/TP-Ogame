using BO.Interface;
using BO.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public class Ressource : IDbEntity, INamableEntity
    {
        private long? id;
        private string name;
        public string Name { get => name; set => name = value; }
        public uint LastQuantity { get; set; }
        [LastUpdateValidator]
        public DateTime LastUpdate { get; set; }
        public long? Id { get => id; set => id = value; }

    }
}