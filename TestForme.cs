using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public class TestForme
    {
        //Forme f1 = new Forme(); //impossible de créer une instance de type abstract, donc elle va engadré une eurreur.
        Rectangle r = new Rectangle(); // c'est bon et évident, c'est la methode traditionelle.
        Cercle c = new Cercle();

        Forme f2 = new Rectangle(); //le polymorphisme repose par la déclaration des objets comme étant des objets de la classe de base.
    }
}
