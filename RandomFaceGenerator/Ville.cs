using System;
using System.Collections.Generic;

namespace CharacterGenerator
{
    
    class Ville
    {
        public Ville()
        {
            Ville_Generation();
        }

        public string ville;

        //Creation d'un nouveau random
        Random random = new Random();

        public void Ville_Generation()
        {
            List<string> villes = new List<string> { "Zrabul", "Losuia", "Rivlan", "Serf-Idule" };
            int Ville = random.Next(villes.Count);
            ville = villes[Ville];
        }

        
    }
}
