using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public abstract class Forme
    {
        protected string couleur;
        protected bool remplie;

        public string GetCouleur()
        {
            return this.couleur;
        }
        public void SetCouleur(string couleur)
        {
            this.couleur = couleur;
        }
        public bool GetRemplie()
        {
            return this.remplie;
        }
        public void SetRemplie(bool remplie)
        {
            this.remplie = remplie;
        }
        public override string ToString()
        {
            return ""+this.couleur+","+this.remplie;
        }
        public abstract double getSurface();
        public abstract double getPerimetre();

    }
}

