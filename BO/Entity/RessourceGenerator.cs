using BO.Entity.Enum;
using BO.Extension;
using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BO.Entity
{



    public abstract class RessourceGenerator : Building
    {

        #region Func


        public virtual Func<uint, double> CalculRessourceAcier
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceOxygene
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceUranium
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceEnergie
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceAcierBySecond
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceOxygeneBySecond
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceUraniumBySecond
        {
            get { return (x) => { return x; }; }
        }

        public virtual Func<uint, double> CalculRessourceEnergieBySecond
        {
            get { return (x) => { return x; }; }
        }

        #endregion

        public override List<Ressource> TotalCost
        {
            get
            {
                return new List<Ressource>()
                    {
                        new Ressource
                        {
                            Name = EnumRessource.ENERGIE.GetName(),
                            LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceEnergie, Level).ToString()),
                            LastUpdate = DateTime.Now
                        },
                        new Ressource
                        {
                            Name = EnumRessource.ACIER.GetName(),
                            LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceAcier, Level).ToString()),
                            LastUpdate = DateTime.Now
                        },
                        new Ressource
                        {
                            Name = EnumRessource.OXYGENE.GetName(),
                            LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceOxygene, Level).ToString()),
                            LastUpdate = DateTime.Now
                        },
                        new Ressource
                        {
                            Name = EnumRessource.URANIUM.GetName(),
                            LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceUranium, Level).ToString()),
                            LastUpdate = DateTime.Now
                        }

                     };
            }
        }

        public virtual List<Ressource> RessourceBySecond
        {
            get
            {
                return new List<Ressource>()
                {
                    new Ressource
                    {
                        Name = EnumRessource.ENERGIE.GetName(),
                        LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceEnergieBySecond, Level).ToString()),
                        LastUpdate = DateTime.Now
                    },
                    new Ressource
                    {
                        Name = EnumRessource.ACIER.GetName(),
                        LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceAcierBySecond, Level).ToString()),
                        LastUpdate = DateTime.Now
                    },
                    new Ressource
                    {
                        Name = EnumRessource.OXYGENE.GetName(),
                        LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceOxygeneBySecond, Level).ToString()),
                        LastUpdate = DateTime.Now
                    },
                    new Ressource
                    {
                        Name = EnumRessource.URANIUM.GetName(),
                        LastQuantity = uint.Parse(Cummulatif.Calculate(CalculRessourceUraniumBySecond, Level).ToString()),
                        LastUpdate = DateTime.Now
                    }

                };
            }

        }

        public virtual List<Ressource> NextCost
        {
            get
            {
                return new List<Ressource>()
                    {
                        new Ressource
                        {
                            Name = EnumRessource.ENERGIE.GetName(),
                            LastQuantity = uint.Parse((this.CalculRessourceEnergie.Invoke(Level)).ToString()),
                            LastUpdate = DateTime.Now
                        },
                        new Ressource
                        {
                            Name = EnumRessource.ACIER.GetName(),
                            LastQuantity = uint.Parse((this.CalculRessourceAcier.Invoke(Level)).ToString()),
                            LastUpdate = DateTime.Now
                        },
                        new Ressource
                        {
                            Name = EnumRessource.OXYGENE.GetName(),
                            LastQuantity = uint.Parse((this.CalculRessourceOxygene.Invoke(Level)).ToString()),
                            LastUpdate = DateTime.Now
                        },
                        new Ressource
                        {
                            Name = EnumRessource.URANIUM.GetName(),
                            LastQuantity = uint.Parse((this.CalculRessourceUranium.Invoke(Level)).ToString()),
                            LastUpdate = DateTime.Now
                        }

                    };
            }
        }

    }


}