using System;
using System.Collections.Generic;

namespace CharacterGenerator
{
    class Charactomancer
    {
        //Variables
        static string CharacterRace;
        static string SubRace;
        static RandGen Random_Generation;
        static Ville Ville_Generation;
        static Royaume Royaume_Generation;
        public static NPC NPC_Generation;       


        public static void FirstRaceChoice()
        {
            Console.WriteLine("C'est l'heure de créer votre personnage ! \nA quelle race souhaitez-vous appartenir ?");
            Console.WriteLine("A) Humain \nB) Elfe \nC) Nain \nD) Gnome \nE) Halfelin");
            CharacterRace = Console.ReadLine();
            CharacterRace = CharacterRace.ToUpper();
            if (CharacterRace == "A")
            {
                Console.WriteLine("Vous êtes un humain, très normal, très basique... très chiant. \n\nMais vous pouvez vous améliorer, quelle race d'humain souhaitez-vous jouer ?");
                CharacterRace = "Humain";
            }
            else if (CharacterRace == "B")
            {
                Console.WriteLine("Vous êtes un fier elfe, très égocentrique, sûrement raciste des autres races et vous vous prennez pas pour de la merde. \nQuel genre d'elfe souhaitez-vous être ?");
                CharacterRace = "Elfe";
            }
            else if (CharacterRace == "C")
            {
                Console.WriteLine("Vous êtes un nain, petit, robuste, solide sur ses appuis et surtout, vous adorez l'or et la bière. \nMais quelle race de Nain souhaitez-vous incarner ?");
                CharacterRace = "Nain";
            }
            else if (CharacterRace == "D")
            {
                Console.WriteLine("Vous êtes un gnome, très petit, très discret, très fourbe mais aussi très sympa. \nQuel genre de Gnome allez-vous jouer ?");
                CharacterRace = "Gnome";
            }
            else if (CharacterRace == "E")
            {
                Console.WriteLine("Vous êtes un halfelin, pas très grand mais très chanceux. Vous incarnez la discretion et l'agilité. \nQuel race d'Halfelin serez-vous ?");
                CharacterRace = "Halfelin";
            }
            SubRaceChoice();
        }

        public static void SubRaceChoice()
        {
            if (CharacterRace == "Humain")
            {
                Console.WriteLine("A) Humain du Nord \nB) Humain du Sud \nC) Humain des îles");
                SubRace = Console.ReadLine();
                SubRace = SubRace.ToUpper();

                if (SubRace == "A")
                {
                    Console.WriteLine("Vous avez choisir d'appartenir au Royaume de Truc, blablablabla");
                    SubRace = "Humain du Nord";
                }

                else if (SubRace == "B")
                {
                    Console.WriteLine("Vous avez choisir d'appartenir au Royaume de Chose, blablablabla");
                    SubRace = "Humain du Sud";
                }

                else if (SubRace == "C")
                {
                    Console.WriteLine("Vous avez choisir de provenir des îles de Machin, blablablabla");
                    SubRace = "Humain des îles";
                }

               



            }
            if (CharacterRace == "Elfe")
            {
                Console.WriteLine("A) Haut-Elfe \nB) Elfe des forêts \nC) Elfe noir");
                SubRace = Console.ReadLine();
                SubRace = SubRace.ToUpper();

                if (SubRace == "A")
                {
                    Console.WriteLine("Vous avez choisir d'être un Haut-Elfe, blablablabla");
                    SubRace = "Haut-Elfe";
                }

                else if (SubRace == "B")
                {
                    Console.WriteLine("Vous avez choisir d'être un Elfe des forêts, blablablabla");
                    SubRace = "Elfe des Forêts";
                }

                else if (SubRace == "C")
                {
                    Console.WriteLine("Vous avez choisir d'être un Elfe Noir, blablablabla");
                    SubRace = "Elfe Noir";
                }


                
            }
            if (CharacterRace == "Nain")
            {
                Console.WriteLine("A) Nain des Montagnes \nB) Nain des Profondeurs \nC) Nain des collines");
                SubRace = Console.ReadLine();
                SubRace = SubRace.ToUpper();

                if (SubRace == "A")
                {
                    Console.WriteLine("Vous avez choisir d'être un Nain des Montagnes, blablablabla");
                    SubRace = "Nain des Montagnes";
                }

                else if (SubRace == "B")
                {
                    Console.WriteLine("Vous avez choisir d'être un Nain des Profondeurs, blablablabla");
                    SubRace = "Nain des Profondeurs";
                }

                else if (SubRace == "C")
                {
                    Console.WriteLine("Vous avez choisir d'être un Nain des Collines, blablablabla");
                    SubRace = "Nain des collines";
                }

            }
            if (CharacterRace == "Gnome")
            {
                Console.WriteLine("A) Gnome des forêts \nB) Gnome des Profondeurs \nC) Gnome des Roches");
                SubRace = Console.ReadLine();
                SubRace = SubRace.ToUpper();

                if (SubRace == "A")
                {
                    Console.WriteLine("Vous avez choisir d'être un Gnome des Forêts, blablablabla");
                    SubRace = "Gnome des Forêts";
                }

                else if (SubRace == "B")
                {
                    Console.WriteLine("Vous avez choisir d'être un Gnome des Profondeurs, blablablabla");
                    SubRace = "Gnome des Profondeurs";
                }

                else if (SubRace == "C")
                {
                    Console.WriteLine("Vous avez choisir d'être un Gnome des Roches, blablablabla");
                    SubRace = "Gnome des Roches";
                }

            }
            if (CharacterRace == "Halfelin")
            {
                Console.WriteLine("A) Halfelin Pieds-Léger \nB) Halfelin Mercurial \nC) Demi-Goblin");
                SubRace = Console.ReadLine();
                SubRace = SubRace.ToUpper();

                if (SubRace == "A")
                {
                    Console.WriteLine("Vous avez choisir d'être un Halfelin Pieds-Léger, blablablabla");
                    SubRace = "Halfelin Pieds-Léger";
                }

                else if (SubRace == "B")
                {
                    Console.WriteLine("Vous avez choisir d'être un Halfelin Mercurial, blablablabla");
                    SubRace = "Halfelin Mercurial";
                }

                else if (SubRace == "C")
                {
                    Console.WriteLine("Vous avez choisir d'être un Demi-Goblin, blablablabla");
                    SubRace = "Demi-Goblin";
                }

            }

            Console.WriteLine("Vous êtes donc un " + SubRace);
            Background();
            
        }

        public static void Background()
        {                     
            Console.WriteLine("Voici votre histoire :");                                 
            Console.ReadKey();
            Console.WriteLine("Vous venez de " + Ville_Generation.ville + " dans le Royaume de " + Royaume_Generation.royaume + ", ce royaume est dirigé par " + NPC_Generation.title +  NPC_Generation.name + " de race " + NPC_Generation.race);
            Console.ReadKey();
        }



        class Program
        {
            

            static void Main()
            {
                Random_Generation = new RandGen();
                Ville_Generation = new Ville();
                Royaume_Generation = new Royaume();
                NPC_Generation = new NPC();
                                
                Console.Title = "Création de personnage";
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string title = @"

 _____                _   _                   _                                                               
/  __ \              | | (_)                 | |                                                              
| /  \/_ __ ___  __ _| |_ _  ___  _ __     __| | ___   _ __   ___ _ __ ___  ___  _ __  _ __   __ _  __ _  ___ 
| |   | '__/ _ \/ _` | __| |/ _ \| '_ \   / _` |/ _ \ | '_ \ / _ \ '__/ __|/ _ \| '_ \| '_ \ / _` |/ _` |/ _ \
| \__/\ | |  __/ (_| | |_| | (_) | | | | | (_| |  __/ | |_) |  __/ |  \__ \ (_) | | | | | | | (_| | (_| |  __/
 \____/_|  \___|\__,_|\__|_|\___/|_| |_|  \__,_|\___| | .__/ \___|_|  |___/\___/|_| |_|_| |_|\__,_|\__, |\___|
                                                      | |                                           __/ |     
                                                      |_|                                          |___/      
";



                Console.WriteLine(title);
                Console.ReadKey();
                Console.ResetColor();
                FirstRaceChoice(); 
                Console.ReadKey();
            }

         
        }
    }
}
