using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_2_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> lesVoitures = new List<Voiture>();
            Electrique voitureelec1 = new Electrique("1", "Mercedes", "très rapide", 100, 200);
            Electrique voitureelec2 = new Electrique("2", "Renault", "normal", 400, 500);
            Thermique voituretherm1 = new Thermique("3", "Honda", "rapide", 600, 700);
            Thermique voituretherm2 = new Thermique("4", "Toyota", "tout terrain", 800, 200);

            lesVoitures.Add(voitureelec1);
            lesVoitures.Add(voitureelec2);
            lesVoitures.Add(voituretherm1);
            lesVoitures.Add(voituretherm2);



            foreach ( Voiture uneVoiture in lesVoitures) 
            {
                uneVoiture.AfficherInfos();
            }

            Console.ReadKey();
        }

    }
}
