using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Royaume
    {
        public Royaume()
        {
            Royaume_Generation();
        }

        public string royaume;
    
        //Creation d'un nouveau random
        Random random = new Random();
        public void Royaume_Generation()
        {
            List<string> royaumes = new List<string> { "Val de Fontenay", "Niort", "Saint-Étienne", "Kebab-Land" };
            int Royaume = random.Next(royaumes.Count);
            royaume = royaumes[Royaume];
        }
    }
}
