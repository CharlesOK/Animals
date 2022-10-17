using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;


   abstract class Animal
    {
        public string AnimalName { get; }
        private string Habitat;
        public string habitat
        {
        get { return Habitat; }
        }

        public string Diet { get; }
       


        protected Animal(string animalName, string habitat, string diet)
        {
            AnimalName = animalName;
            Habitat = habitat;
            Diet = diet;
        }

        public abstract string AnimalSounds();
        

        public override string ToString()
        {
            return " " + AnimalName;
        }
    }
