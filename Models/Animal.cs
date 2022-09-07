using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;


   public class Animal
    {
        public string AnimalName { get; }

     private string Habitat;
        public string habitat
    {
        get { return Habitat; }
    }

        public string Diet { get; }
        public string SoundOfAnimal { get; }


        protected Animal(string animalName, string habitat, string diet)
        {
            AnimalName = animalName;
            Habitat = habitat;
            Diet = diet;
        }

        public virtual string AnimalSounds()
        {
            return SoundOfAnimal;
        }

        public override string ToString()
        {
            return string.Format("{0}", AnimalName);
        }
    }
