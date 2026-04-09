using System;
using System.Collections.Generic;
using System.Data;

namespace projetFoxmon
{
	public class Foxmon
	{

		public string Nom { get; set; }
		public int PV { get; set; }
		public int PVM { get; set; }
		public int LVL { get; set; }
		public int Speed { get; set; }
		public int Degats { get; set; }
		public string TypeElementaire { get; set; }

		public Foxmon(string nom, int pv, int pvm, int lvl, int speed, int degats, string typeElementaire)
		{
			Nom = nom;
			PV = pv;
			PVM = pvm;
			LVL = lvl;
			Speed = speed;
			Degats = degats;
			TypeElementaire = typeElementaire;
		}

		public void AfficherInfo()
		{
			Console.WriteLine($" Voici {Nom}, ");
		}

		public void Attaquer(Foxmon cible)
		{
			int degatsbase = Degats;
			double multiplicateur = 1;
			if (TypeElementaire == "Feu" && cible.TypeElementaire == "Plante")
			{
				multiplicateur = 2;
				Console.WriteLine("C'est super efficace !");
			}
			else if (TypeElementaire == "Feu" && cible.TypeElementaire == "Eau")
			{
				multiplicateur = 0.5;
				Console.WriteLine("C'est super efficace !");
			}
			else if (TypeElementaire == "Feu" && cible.TypeElementaire == "Feu")
			{
				multiplicateur = 0.5;
				Console.WriteLine("C'est super efficace !");
			}
			else if(TypeElementaire == "Feu" && cible.TypeElementaire == "Métal")
			{
				multiplicateur = 0.5;
				Console.WriteLine("C'est sup efficace !");
			}
			int degatsinfliges = (int)(degatsbase * multiplicateur);
			cible.PV -= degatsinfliges;
			if (cible.PV < 0)
			{
				cible.PV = 0;
			}
		}
	}
}