using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie2_TP1_GestionEmployee
{
    internal class Directeur
    {
        private static Directeur instance;
        private GestionEmployes gestionEmployes;

        private Directeur()
        {
            gestionEmployes = new GestionEmployes();
        }

        public static Directeur GetInstance()
        {
            if (instance == null)
            {
                instance = new Directeur();
            }
            return instance;
        }

        public void SetGestionEmployes(GestionEmployes gestion)
        {
            gestionEmployes = gestion;
        }

        public void AfficherStatistiques()
        {
            Console.WriteLine($"\n=== Statistiques de l'entreprise ===");
            Console.WriteLine($"Salaire total : {gestionEmployes.CalculerSalaireTotal()} Dhs");
            Console.WriteLine($"Salaire moyen : {gestionEmployes.CalculerSalaireMoyen()} Dhs");
        }
    }
}
