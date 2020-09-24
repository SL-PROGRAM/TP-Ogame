using BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public class SolarSystem : IDbEntity, INamableEntity

    {
        private long? id;
        public long? Id { get => id; set => id = value; }
        private string name;
        public string Name{ get => name; set => name = value; }
        public virtual List<Planet> planets { get; set; } = new List<Planet>();

    }
}