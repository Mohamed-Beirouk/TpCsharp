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
        public string GetCouleur()
        {
            return this.couleur;
        }
        public int GetPrix()
        {
            return this.prix;
        }






    }
}
