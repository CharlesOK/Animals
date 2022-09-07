using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class AnimalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["mammals"] == null) || (Session["reptiles"] == null) || (Session["selectedAnimal"] == null))
            {
                Response.Redirect("AnimalSelection.aspx");
            }
            Mammal[] mammals = (Mammal[])Session["mammals"];
            Reptiles[] reptiles = (Reptiles[])Session["reptiles"];

            List<Mammal> selectedAnimals = (List<Mammal>)Session["selectedAnimals"];
            Reptiles selectedReptile = (Reptiles)Session["selectedReptile"];


            // Mammal mammals1 = selectedAnimal;
            Reptiles reptiles2 = selectedReptile;
            Animals.Text = "";

            Mammal animal;
            Reptiles reptile;
            switch (Session["searchedAnimal"])
            {
                case "cheetah":
                    animal = new Mammal(12, 90, "Purr", "Cheetah", "A.Jubatus", "Africa", "Carnivore");
                    break;
                case "elephant":
                    animal = new Mammal(70, 22, "Trumpeting", "Elephant", "African Bush Elephant", "Sub-Saharan Africa", "Herbivore");
                    break;
                case "lion":
                    animal = new Mammal(14, 110, "Roar", "Lion", "Panthera leo", "Sub-Saharan Africa", "Carnivore");
                    break;
                case "dog":
                    animal = new Mammal(13, 63, "Bark", "Dog", "Alaskan Husky", "North-America", "Omnivore");
                    break;
                case "cat":
                    animal = new Mammal(18, 67, "Meow", "Cat", "Bob-Cat", "North-America", "Carnivore");
                    break;
                case "horse":
                    animal = new Mammal(40, 370, "Neigh", "Horse", "Equus Caballus", "North-America", "Herbivore");
                    break;
                default:
                   animal = null;
                    break;
            }


            switch (Session["searchedAnimal"])
            {
                case "snake":
                    reptile = new Reptiles(8, 1, "Hissing", "Snake", "Green Snake", "North-America", "Carnivore");
                    break;
                case "turtle":
                    reptile = new Reptiles(150, 90, "Grunting", "Turtle", "Green Sea Turtle", "Ocean", "Omniivore");
                    break;
                case "komodo dragon":
                    reptile = new Reptiles(30, 9, "Trumpeting", "Komodo-Dragon", "Varanus Komodoensis", "Asia", "Carnivore");
                    break;
                case "crocodile":
                    reptile = new Reptiles(40, 75, "Bellow", "Crocodile", "Nile-Crocodile", "Africa", "Carnivore");
                    break;
                case "chameleon":
                    reptile = new Reptiles(70, 22, "No-Sound", "Chameleon", "Panther Chameleon", "North-America", "Herbivore");
                    break;
                case "lizard":
                    reptile = new Reptiles(50, 100, "Hissing", "Lizard", "Frilled Neck lizard", "Australia", "Herbivore");
                    break;
                default:
                    reptile = null;
                    break;
            }


            if (animal != null)
            {
                Animals.Text += "Animal name: " + animal.ToString();
                Animals.Text += "<br />Animal : " + animal.habitat;
                Animals.Text += "<br />Gestation period in months/days: " + animal.GestationPeriod;
                Animals.Text += "<br />Animal Diet: " + animal.Diet;
                Animals.Text += "<br />Animal Lifespan: " + animal.LifeSpan;
                Animals.Text += "<br />Animal sound: " + animal.AnimalSounds();
                Animals.Text += "<br />Is the animal a vertebrate: " + animal.isVertebrae;
                Animals.Text += "<br />Animal species: " + animal.Species + "<br /><br /><br />";
            }

            if (reptile != null)
            {
                Animals.Text += "Animal name: " + reptile.ToString();
                Animals.Text += "<br />Animal : " + reptile.habitat;
                Animals.Text += "<br />Gestation period in months/days: " + reptile.GestationPeriod;
                Animals.Text += "<br />Animal Diet: " + reptile.Diet;
                Animals.Text += "<br />Animal Lifespan: " + reptile.LifeSpan;
                Animals.Text += "<br />Animal sound: " + reptile.AnimalSounds();
                Animals.Text += "<br />Is the animal a vertebrate: " + reptile.isVertebrae;
                Animals.Text += "<br />Animal species: " + reptile.Species + "<br /><br /><br />";
            }

            if (selectedAnimals != null) {
                selectedAnimals.ForEach(mammals1 =>
                {
                    Animals.Text += "Animal name: " + mammals1.ToString();
                    Animals.Text += "<br />Animal : " + mammals1.habitat;
                    Animals.Text += "<br />Gestation period in months/days: " + mammals1.GestationPeriod;
                    Animals.Text += "<br />Animal Diet: " + mammals1.Diet;
                    Animals.Text += "<br />Animal Lifespan: " + mammals1.LifeSpan;
                    Animals.Text += "<br />Animal sound: " + mammals1.AnimalSounds() ;
                    Animals.Text += "<br />Is the animal a vertebrate: " + mammals1.isVertebrae;
                    Animals.Text += "<br />Animal species: " + mammals1.Species + "<br /><br /><br />";
                });
            }


            if (selectedReptile != null)
            {
                Animals.Text += "Animal name: " + reptiles2.ToString() + "<br />";
                Animals.Text += "Animal Habitat: " + reptiles2.habitat + "<br />";
                Animals.Text += "Gestation period in months/days: " + reptiles2.GestationPeriod + "<br />";
                Animals.Text += "Animal Diet: " + reptiles2.Diet + "<br />";
                Animals.Text += "Animal Lifespan: " + reptiles2.LifeSpan + "<br />";
                Animals.Text += "Animal sound: " + reptiles2.AnimalSounds() + "<br />";
                Animals.Text += "Is the animal a vertebrate: " + reptiles2.isVertebrae + "<br />";
                Animals.Text += "Animal species: " + reptiles2.Species;
            }

        }


    }
}
