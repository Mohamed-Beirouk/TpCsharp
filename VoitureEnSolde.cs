using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public class VoitureEnSolde : Voiture
    {
        private double remise=0.2;
        public override int GetPrix()
        {

            return (int)(base.GetPrix() - base.GetPrix() * this.remise);

        }
    }
}
