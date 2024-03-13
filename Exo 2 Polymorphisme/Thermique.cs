using System;
namespace Exo_2_Polymorphisme
{
    class Thermique : Voiture
    {

        private int typeCarburant;

        public Thermique(string uneImmat, string uneMarque, string unModele, int unePuissanceFiscale, int unType)
        {
            immat = uneImmat ;
            marque = uneMarque ;
            modele = unModele ;
            puissanceFiscale = unePuissanceFiscale ;
            typeCarburant = unType ;
        }

        public override void AfficherInfos()
        {
            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine("Voici le numéro d'immatriculation : " + immat);
            Console.WriteLine("Voici la marque : " + marque);
            Console.WriteLine("Voici le model : " + modele);
            Console.WriteLine("Voici la puissance fiscal : " + puissanceFiscale);
            Console.WriteLine("Voici la quantité     de carburant : " + typeCarburant);
            Console.WriteLine("-----------------------------------------------------\n");

        }

    }
}
