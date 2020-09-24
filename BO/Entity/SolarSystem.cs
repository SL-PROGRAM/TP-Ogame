using BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{
    public class SolarSystem : IDbEntity

    {
        private long? id;
        private string name;
        private List<Planet> planets = new List<Planet>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public long? Id { get => id; set => id = value; }
    }
}