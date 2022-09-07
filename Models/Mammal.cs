using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class Mammal : Animal
    {
        public int LifeSpan { get; }
        public int GestationPeriod { get; }

        public string SoundOfMammals { get; }
        public bool isVertebrae { get; }
        public string Species { get; }

        public Mammal(int lifeSpan, int gestationPeriod, string soundOfAnimal,string animalName, string species, string habitat, string diet) :base(animalName, habitat, diet)
        {
            LifeSpan = lifeSpan;
            GestationPeriod = gestationPeriod;
            SoundOfMammals = soundOfAnimal;
            isVertebrae = true;
            Species = species;
        }

        public override string AnimalSounds()
        {
            return SoundOfMammals;
        }
    }
