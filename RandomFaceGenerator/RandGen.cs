using System;
using System.Collections.Generic;

namespace CharacterGenerator
{
    class RandGen
    {
        public string ville;
        public string royaume;
        public string genre;
        public string genre_dirigeant;

        public RandGen()
        {
            BackgroundGeneration();            
        }

        public void BackgroundGeneration()
        {
            //Lancement de la randomisation
            Random random = new Random();


            //Liste des paramètres à randomiser
            List<string> villes = new List<string> { "Zrabul", "Losuia", "Rivlan", "Serf-Idule" };
            List<string> royaumes = new List<string> { "Val de Fontenay", "Niort", "Saint-Étienne", "Kebab-Land" };
            List<string> dirigeants = new List<string> { "Rothchild", "Nicsomatosis", "MisterEmevé", "Benalla" };
            List<string> dirigeantes = new List<string> { "Bowsette", "Booette", "Pistachette", "Benallette" };
            List<string> type_dirigeants = new List<string> { "le Roi", "l'Empereur", "le Duc", "le King", "l'Influenceur", "le Chef de la startup nation" };
            List<string> type_dirigeantes = new List<string> { "la Reine", "l'Impératrice", "la Duchesse", "la Kingette", "l'Influenceuse", "la Cheffe de la startup nation" };

            //Randomisation de chaque liste et choix
            int index1 = random.Next(villes.Count);
            int index2 = random.Next(royaumes.Count);
            int index3 = random.Next(type_dirigeants.Count);
            int index4 = random.Next(dirigeants.Count);
            int index5 = random.Next(type_dirigeantes.Count);
            int index6 = random.Next(dirigeantes.Count);

            //Définition du genre 
            int est_une_femme = (int)random.Next(2);
            genre = est_une_femme == 1 ? type_dirigeantes[index5] : type_dirigeants[index3];
            genre_dirigeant = (est_une_femme == 1) ? dirigeantes[index6] : dirigeants[index4];

            ville = villes[index1];
            royaume = royaumes[index2];     
            
            

            
        }

        

    }
}
