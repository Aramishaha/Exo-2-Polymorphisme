using System;
namespace Exo_2_Polymorphisme

{
    class Electrique : Voiture
    {
        private int capaciteBatterie;

        public Electrique(string uneImmat, string uneMarque, string unModele, int unePuissanceFiscale, int uneCapacite) 
        {
            immat = uneImmat ;
            marque = uneMarque ;
            modele = unModele ;
            puissanceFiscale = unePuissanceFiscale ;
            capaciteBatterie = uneCapacite ;
        }

        public override void AfficherInfos()
        {
            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine("Voici le numéro d'immatriculation : " + immat);
            Console.WriteLine("Voici la marque : " + marque);
            Console.WriteLine("Voici le model : " + modele);
            Console.WriteLine("Voici la puissance fiscal : " + puissanceFiscale);
            Console.WriteLine("Voici la capacité électrique : " + capaciteBatterie);
            Console.WriteLine("-----------------------------------------------------\n");

        }
    }
}
