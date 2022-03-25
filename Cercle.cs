using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public class Cercle : Forme
    {
        private int rayon;

        public override double getSurface()
        {
            return this.rayon * this.rayon * Math.PI;
        }
        public override double getPerimetre()
        {
            return 2 * Math.PI * this.rayon;
        }
        public override string ToString()
        {
            return "" + base.couleur + "," + base.remplie + "," + this.rayon + ",";
        }

    }
}
