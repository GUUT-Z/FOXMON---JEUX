using System;
using System.Collections.Generic;
using System.Data;

namespace projetFoxmon
{
    public class Dresseur
    {
        public string Nom { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private List<Foxmon> Equipe { get; set; }

        public Dresseur(string nom, int x, int y)
        {

            Nom = nom;
            X = x;
            Y = y;
            Equipe = new List<Foxmon>();

        }

        public void AjouterSiPossible(Foxmon foxmon, int maxEquipe = 6)
        {
            if (Equipe.Count < maxEquipe)
            {
                Equipe.Add(foxmon);
            }
            else
            {
                Console.WriteLine("Votre équipe est déjà complète !");
            }
        }

        public Foxmon PremierFoxmon()
        {
            if (Equipe.Count > 0)
            {
                return Equipe[0];
            }
            else
            {
                return null;
            }
        }

        public bool Capturer(Foxmon cible)
        {
            if (cible.PV < cible.PVM / 4 && Equipe.Count < 6)
            {
                Equipe.Add(cible);
                Console.WriteLine($"{Nom} a capturé {cible.Nom} !");
                return true;
            }
            else
            {
                Console.WriteLine($"{Nom} a échoué à capturer {cible.Nom}.");
                return false;
            }
        }
        
        public bool Fuir()
        {
        ConsoleKey touche = Console.ReadKey(true).Key;
        if (touche == ConsoleKey.Escape)
        {
            Console.WriteLine("T'as fui le combat.");
            return true;
        }
        return false;
        }

        public Foxmon ProchainFoxmonDisponible()
        {
            foreach(var f in Equipe)
            {
                if(f.PV > 0)
                    return f;
            }
            return Equipe[0];
        }
    }

}