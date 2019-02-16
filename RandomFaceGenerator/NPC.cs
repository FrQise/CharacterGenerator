using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//https://github.com/Cellule/dndGenerator/tree/master/src/npcData/tables

namespace CharacterGenerator
{
    class NPC
    {
        public string genre_choice;
        public string name;
        public string title;
        public string race;
        public string relationship;
        

        public NPC()
        {
            Genre();
            Name();
            Title();
            Race();
            Relationship();
        }

        public void Genre()
        {
            Random genre = new Random();
            List<string> genres = new List<string> { "Female", "Male" };
            int Genre = genre.Next(genres.Count);
            genre_choice = genres[Genre];

        }
        public void Name()
        {
            if (genre_choice == "Male")
            {
                Random name_random = new Random();
                List<string> names = new List<string> { "Jean", "Paul", "Roger", "Fabien" };
                int Name = name_random.Next(names.Count);
                name = names[Name];
            }

            else if (genre_choice == "Female")
            {
                Random name_random = new Random();
                List<string> names = new List<string> { "Pauline", "Marie", "Julia", "Rose" };
                int Name = name_random.Next(names.Count);
                name = names[Name];
            }
        }

        public void Title()
        {
            if (genre_choice == "Male")
            {
                Random title_random = new Random();
                List<string> titles = new List<string> { "le Duc ", "le Roi ", "le Chef ", "l'Empereur " };
                int Title = title_random.Next(titles.Count);
                title = titles[Title];
            }

            else if (genre_choice == "Female")
            {
                Random title_random = new Random();
                List<string> titles = new List<string> { "la Duchesse ", "la Reine ", "la Cheffe ", "l'Impératrice " };
                int Title = title_random.Next(titles.Count);
                title = titles[Title];
            }
        }


        public void Race()
        {
            if (genre_choice == "Male")
            {
                Random race_random = new Random();
                List<string> races = new List<string> { "Humain", "Nain" , "Gnome" , "Halfelin" , "Elfe" };
                int Race = race_random.Next(races.Count);
                race = races[Race];
            }

            else if (genre_choice == "Female")
            {
                Random race_random = new Random();
                List<string> races = new List<string> { "Humaine", "Naine", "Gnomette", "Halfeline", "Elfe" };
                int Race = race_random.Next(races.Count);
                race = races[Race];
            }

        }

        public void Subrace()
        {
           List<string> subrace = new List<string> { };
        }

        public void Description()
        {
           List<string> description = new List<string> { };

        }

        public void Classorprof()
        {
            List<string> classorprof = new List<string> { };

        }

        public void Plothook()
        {
            List<string> ploothook = new List<string> { };
        }

        public void Relationship()
        {
            Random relationship_random = new Random();
            string RelationshipTextPath = @"C:\Users\hiryu\source\repos\RandomFaceGenerator\RandomFaceGenerator\Relationship.txt";
            List<string> relationships = File.ReadAllLines(RelationshipTextPath).ToList();
            foreach(string line in relationships)
            {
                string[] entries = line.Split(',');
                int Relationship = relationship_random.Next(relationships.Count);
                relationship = relationships[Relationship];
            }
            
            
        }

        public void Religion()
        {
            List<string> religions = new List<string> { };
        }

        public void PersonalTrait()
        {
            List<string> PT_1 = new List<string> { };
            List<string> PT_2 = new List<string> { };
            List<string> PT_3 = new List<string> { };
            List<string> PT_4 = new List<string> { };
            List<string> PT_5 = new List<string> { };
        }
        
        
    }
}
