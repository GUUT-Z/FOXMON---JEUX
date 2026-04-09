using System;
using System.Collections.Generic;
using System.Data;
namespace projetFoxmon
{
	public class Program
	{
		public static void Main()
		{
			Carte carte1 = new Carte();
			Dresseur joueur = new Dresseur("babacar", 1, 1);

			Foxmon fox1 = new Foxmon("Pyrolion", 100, 100, 5, 10, 20, "feu");
			Foxmon fox2 = new Foxmon("Aquafluff", 90, 90, 4, 9, 18, "Eau");
			Foxmon fox3 = new Foxmon("Leafling", 80, 80, 3, 8, 15, "plante");
			Foxmon fox4 = new Foxmon("Frostrix", 85, 85, 4, 7, 17, "Glace"); 
			Foxmon fox5 = new Foxmon("Ironfang", 95, 95, 5, 6, 19, "Métal");
			Foxmon fox6 = new Foxmon("Zippit", 70, 70, 3, 12, 16, "Électrique");

			joueur.AjouterSiPossible(fox1);
			joueur.AjouterSiPossible(fox2);
			joueur.AjouterSiPossible(fox3);
			joueur.AjouterSiPossible(fox4);
			joueur.AjouterSiPossible(fox5);
			joueur.AjouterSiPossible(fox6);

			Random rnd = new Random();
			//Liste de foxmon sauvage
			List<Foxmon> FoxmonsSauvages = new List<Foxmon>
			{
				new Foxmon("Emberpaw", 70, 70, 2, 9, 16, "feu"),
				new Foxmon("Bubbluff", 60, 60, 2, 8, 14,"Eau"),
				new Foxmon("Spriggle", 75, 75, 3, 7, 12,"Plante"),
				new Foxmon("Rockpaw", 80, 80, 4, 6, 18,"Roche"),
				new Foxmon("zippit", 65, 65, 3, 12, 15,"Electrique"),
				new Foxmon("Glaciraptor", 80, 80, 3, 7, 15, "Glace"),
				new Foxmon("Steelbite", 85, 85, 4, 6, 18, "Métal"),
				new Foxmon("Terraquake", 100, 100, 5, 8, 20, "Sol")
			};

			Console.CursorVisible = false; // optionnel (cache le curseur)

			// Afficher la carte UNE seule fois
			Console.Clear();
			carte1.Afficher();

			// Afficher le joueur au départ
			Console.SetCursorPosition(joueur.X, joueur.Y);
			Console.Write('P');

			bool enCombat = false;

			while (true)
			{
				Console.Clear();
				carte1.Afficher();
				// Effacer ancienne position du joueur
				Console.SetCursorPosition(joueur.X, joueur.Y);
				Console.Write('P');

				// Lire la touche
				ConsoleKey key = Console.ReadKey(true).Key;

				int newX = joueur.X;
				int newY = joueur.Y;

				// Gestion des déplacements
				if (key == ConsoleKey.UpArrow) newY--;
				if (key == ConsoleKey.DownArrow) newY++;
				if (key == ConsoleKey.RightArrow) newX++;
				if (key == ConsoleKey.LeftArrow) newX--;

				// Vérifier si on peut marcher
				if (carte1.EstTraversable(newX, newY))
				{
					joueur.X = newX;
					joueur.Y = newY;

					if (carte1.EstHauteHerbe(newX, newY) && rnd.Next(100) < 50)
					{
						enCombat = true;
					}
					if (enCombat == true)
					{
						Console.Clear();
						
						Foxmon monFoxmon = joueur.PremierFoxmon();
						//gestion des foxmons sauvages
						if(monFoxmon != null)
						{
							Foxmon foxmonSauvage = FoxmonsSauvages[rnd.Next(FoxmonsSauvages.Count)];
							Foxmon foxmonsauvage = new Foxmon(
								foxmonSauvage.Nom,
								foxmonSauvage.PV,
								foxmonSauvage.PVM,
								foxmonSauvage.LVL,
								foxmonSauvage.Speed,
								foxmonSauvage.Degats,
								foxmonSauvage.TypeElementaire
							); 

							while(enCombat)
							{
								Console.Clear();

								Console.WriteLine($"Un {foxmonsauvage.Nom} sauvage apparaît !");
								Console.WriteLine($"Combattre avec {monFoxmon.Nom}");
								Console.WriteLine("");

								Console.WriteLine("A = Attaquer");
								Console.WriteLine("C = Capturer");
								Console.WriteLine("Espace = Fuir");

								ConsoleKey action = Console.ReadKey(true).Key;

								if (action == ConsoleKey.A)
								{
									monFoxmon.Attaquer(foxmonsauvage);
									Console.WriteLine($"{monFoxmon.Nom} attaque {foxmonsauvage.Nom} !");
									Console.WriteLine($"{foxmonsauvage.Nom} a {foxmonsauvage.PV} PV restants.");

									if (foxmonsauvage.PV <= 0)
									{
										Console.WriteLine($"{foxmonsauvage.Nom} est vaincu !");
										enCombat = false;
									}
									else
									{
										foxmonSauvage.Attaquer(monFoxmon);
										Console.WriteLine($"{foxmonSauvage.Nom} contre-attaque !");
										Console.WriteLine($"Il reste {monFoxmon.PV} PV à ton {monFoxmon.Nom}");
									}
								}
								else if (action == ConsoleKey.Spacebar)
								{
									Console.WriteLine("Vous fuyez !");
									enCombat = false;
									
								}
								else if(action == ConsoleKey.C)
								{
									bool capture = joueur.Capturer(foxmonsauvage);
									if(capture)
									{
										enCombat = false;
										Console.WriteLine($"Vous avez capturer {foxmonsauvage.Nom}");
									}
								}
								Console.ReadKey(true);
							}               
						}
						else
						{
							Console.WriteLine("pas de Foxmon disponible!!!");
							Console.ReadKey(true);
							enCombat = false;
						}
					}
				} 
			}	   
		}	
	}
}