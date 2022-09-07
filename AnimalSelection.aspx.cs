using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{

    public partial class AnimalSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mammal[] mammals;
            Reptiles[] reptiles;

            if ((Session["mammals"] == null) || (Session["reptiles"] == null))
            {

                mammals = new Mammal[6];
                mammals[0] = new Mammal(70, 22, "Trumpeting", "Elephant", "African Bush Elephant", "Sub-Saharan Africa", "Herbivore");
                mammals[1] = new Mammal(14, 110, "Roar", "Lion", "Panthera leo", "Sub-Saharan Africa", "Carnivore");
                mammals[2] = new Mammal(13, 63, "Bark", "Dog", "Alaskan Husky", "North-America", "Omnivore");
                mammals[3] = new Mammal(18, 67, "Meow", "Cat", "Bob-Cat", "North-America", "Carnivore");
                mammals[4] = new Mammal(40, 370, "Neigh", "Horse", "Equus Caballus", "North-America", "Herbivore");
                mammals[5] = new Mammal(12, 90, "Purr", "Cheetah", "A.Jubatus", "Africa", "Carnivore");


                reptiles = new Reptiles[6];
                reptiles[0] = new Reptiles(150, 90, "Grunting", "Turtle", "Green Sea Turtle", "Ocean", "Omniivore");
                reptiles[1] = new Reptiles(50, 100, "Hissing", "Lizard", "Frilled Neck lizard", "Australia", "Herbivore");
                reptiles[2] = new Reptiles(70, 22, "No-Sound", "Chameleon", "Panther Chameleon", "North-America", "Herbivore");
                reptiles[3] = new Reptiles(8, 1, "Hissing", "Snake", "Green Snake", "North-America", "Carnivore");
                reptiles[4] = new Reptiles(40, 75, "Bellow", "Crocodile", "Nile-Crocodile", "Africa", "Carnivore");
                reptiles[5] = new Reptiles(30, 9, "Trumpeting", "Komodo-Dragon", "Varanus Komodoensis", "Asia", "Carnivore");



                Session["mammals"] = mammals;
                Session["reptiles"] = reptiles;
            }
            else
            {
                mammals = (Mammal[])Session["mammals"];

                reptiles = (Reptiles[])Session["reptiles"];

            }

            if (!IsPostBack)
            {
                checkList.Items.Add(mammals[0].AnimalName);
                checkList.Items.Add(mammals[1].AnimalName);
                checkList.Items.Add(mammals[2].AnimalName);
                checkList.Items.Add(mammals[3].AnimalName);
                checkList.Items.Add(mammals[4].AnimalName);
                checkList.Items.Add(mammals[5].AnimalName);

                RadioButton1.Items.Add(reptiles[0].AnimalName);
                RadioButton1.Items.Add(reptiles[1].AnimalName);
                RadioButton1.Items.Add(reptiles[2].AnimalName);
                RadioButton1.Items.Add(reptiles[3].AnimalName);
                RadioButton1.Items.Add(reptiles[4].AnimalName);
                RadioButton1.Items.Add(reptiles[5].AnimalName);



            }

        }

        protected void AnimalDetails(object sender, EventArgs e)
        {
           
            List<Mammal> mammalList = new List<Mammal>();
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                if (checkList.Items[i].Selected)
                {
                    Mammal[] allMammals = (Mammal[])Session["mammals"];
                    mammalList.Add(allMammals[i]);
                    Session["selectedAnimal"] = allMammals[i];
                }
            }
            Session["selectedAnimals"] = mammalList;
            if (RadioButton1.SelectedIndex > -1)
            {
                Reptiles[] allReptiles = (Reptiles[])Session["reptiles"];
                Session["selectedReptile"] = allReptiles[RadioButton1.SelectedIndex];
                

            }

            Session["searchedAnimal"] = animal_textBox.Text.ToLower();  

            
            Response.Redirect("AnimalDetails.aspx");
        }
    }
}