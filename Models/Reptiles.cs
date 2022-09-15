using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

     class Reptiles : Animal
    {
        public int LifeSpan { get; }
        public int GestationPeriod { get; }

        public bool isVertebrae { get; }
        public string Species { get; }

        public string SoundOfReptiles { get; }

        public Reptiles(int lifeSpan, int gestationPeriod, string soundofanimal,string animalName,string species, string habitat, string diet ) :base(animalName, habitat, diet)
        {
            LifeSpan = lifeSpan;
            Species = species;
            SoundOfReptiles = soundofanimal;
            GestationPeriod = gestationPeriod;
            isVertebrae = true;
        }

        public override string AnimalSounds()
        {
            return SoundOfReptiles;
        }
    }
