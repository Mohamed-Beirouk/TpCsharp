using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPoop
{
    public class TestVoiture
    {

        static void Main(string[] args)
        {
            Voiture v1 = new Voiture();
            Voiture v2 = new Voiture(40000,"Noir");

            v2.GetMarque();

            Console.WriteLine(v2);


        }

    }
}
