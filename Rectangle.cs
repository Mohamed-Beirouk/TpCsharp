using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public class Rectangle : Forme
    {
        private int longeur;
        private int largeur;

        public override double getSurface()
        {
            return this.longeur * this.largeur;
        }
        public override double getPerimetre()
        {
            return (this.longeur + this.largeur) * 2;
        }

        public override string ToString()
        {
            return "" + base.couleur + "," + base.remplie + "," + this.longeur + "," + this.largeur + ",";
        }

    }
}
