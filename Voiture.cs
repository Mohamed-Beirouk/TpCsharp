using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public class Voiture
    {
        private string modele;
        private string marque;
        private string couleur;
        private int prix;
        private int puissance;
        public Voiture()
        {
        }
        public Voiture(string modele)
        {
            this.modele = modele;
        }

        public Voiture(int prix, string couleur)
        {
            this.prix = prix;
            this.couleur = couleur;
        }
        public string GetCouleur()
        {
            return this.couleur;
        }
        public virtual int GetPrix()
        {
            return this.prix;
        }
        public string GetMarque()
        {
            return this.marque;
        }
        public void SetMarque(string marque)
        {
            this.marque = marque;
        }
        public void SetCouleur(string couleur)
        {
            this.couleur = couleur;
        }

        public override string ToString()
        {
            return "" + this.modele + "," + this.couleur + "," + this.prix + "," + this.puissance + ",";
        }


        public Boolean Equals(Voiture v)
        {
            return (
            (this.modele == v.modele) &&
            (this.couleur == v.couleur) &&
            (this.prix == v.prix) &&
            (this.puissance == v.puissance) 
            );
        }








    }
}
