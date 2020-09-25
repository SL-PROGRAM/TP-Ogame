using BO.Entity.Enum;
using BO.Extension;
using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity.ConcreatBuilding
{
    public class PowerPlant : RessourceGenerator
    {
        #region Func

       
        public override Func<uint, double> CalculRessourceAcier
        {
            get { return (x) => { return (1 * x) + ((200 * (x / 10.0)) + 20); }; }
        }

        public override Func<uint, double> CalculRessourceOxygene
        {
            get { return (x) => { return 1 * Level + (100 * (Level / 8.0)) + 20; }; }
        }

        public override Func<uint, double> CalculRessourceUranium
        {
            get { return (x) => { return 3 * Math.Pow(Level, 3) + (200 * (Level / 20.0)) + 20; }; }
        }

        public override Func<uint, double> CalculRessourceEnergie
        {
            get { return (x) => { return (1 * x); }; }
        }

        public override Func<uint, double> CalculRessourceAcierBySecond
        {
            get { return (x) => { return 0; }; }
        }

        public override Func<uint, double> CalculRessourceOxygeneBySecond
        {
            get { return (x) => { return 0; }; }
        }

        public override Func<uint, double> CalculRessourceUraniumBySecond
        {
            get { return (x) => { return 0; }; }
        }

        public override Func<uint, double> CalculRessourceEnergieBySecond
        {
            get { return (x) => { return 3*Level +10 ; }; }
        }

        #endregion




    }
}
