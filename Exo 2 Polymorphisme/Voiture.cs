using System;
namespace Exo_2_Polymorphisme
{
    abstract class Voiture 
    {
        protected string immat;
        protected string marque;
        protected string modele;
        protected string type;
        protected int puissanceFiscale;

        public abstract void AfficherInfos();

    }
}
