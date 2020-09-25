using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity.ConcreatBuilding
{
    class UraniumGenerator : RessourceGenerator
    {
        #region Func


        public override Func<uint, double> CalculRessourceAcier
        {
            get { return (x) => { return Level; }; }
        }

        public override Func<uint, double> CalculRessourceOxygene
        {
            get { return (x) => { return 200*(Level/2.0)+20; }; }
        }

        public override Func<uint, double> CalculRessourceUranium
        {
            get { return (x) => { return  0 ; }; }
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
            get { return (x) => { return 7*Math.Pow(Level, 3)+5; }; }
        }

        public override Func<uint, double> CalculRessourceEnergieBySecond
        {
            get { return (x) => { return 0; }; }
        }

        #endregion
    }
}
