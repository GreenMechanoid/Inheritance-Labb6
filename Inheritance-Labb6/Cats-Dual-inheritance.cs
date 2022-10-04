using Petting_Zoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petting_Zoo
{
    internal class Cats : Animal
    {
        protected string CurrentMood; // unique identifier for Cats, as they can be tempremental

        public Cats(string name, int appendages, int age
            , string animalDiet, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, string breed, string mood)
        {
            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.AnimalDiet = animalDiet;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
            this.CurrentLocation = location;
            this.Breed = breed;
            this.CurrentMood = mood;
        }
        public Cats() 
        //empty with default values
        {
            this.Breed = "Tabby mcTabbington";
            this.CurrentMood = "Not Amused";

            this.Name = "Terror of McError";
            this.NumberOfAppendages = 4;
            this.Age = 6428;
            this.AnimalDiet = "Carnivore";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.CurrentLocation = "Middle of St.Maria's Church (by mistake)";
            this.Sound = "Meow!, i'm a ExtraSolar being, stop fussing over me Human!";

        }
        public void ChangeMood() //simple usage of unique variable in a method
        {
            string inputString;
            Console.WriteLine("Current mood of {0} is {1}, Has it's mood changed? Y/any", this.Name, this.CurrentMood);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("What is the New mood of {0} then?",this.Name);
                Console.Write("What's the Mood? : ");
                inputString = Console.ReadLine();
                this.CurrentMood = inputString;
                Console.WriteLine("\n{0} Mood has now been changed to {1}", this.Name, this.CurrentMood);
            }
            else
            {
                Console.WriteLine("\nWell {0} we can't really force the issue.. so stay {1}",this.Name,this.CurrentMood);
            }
        }
    }

    internal class Manx : Cats
    {
        protected string CatQuirk; // unique to Manx
        public Manx(string mood, string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, string catQuirk)
        {
            this.Breed = "Manx";
            this.CurrentMood = mood;

            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
            this.CurrentLocation = location;
            this.CatQuirk = catQuirk;
        }
        public Manx()
        {
            this.Breed = "I'm not a proper Instance";
            this.CurrentMood = "Pissed at subordinate for drugs";

            this.Name = "Captain. Floofers the second";
            this.NumberOfAppendages = 4;
            this.Age = 8844;
            this.AnimalDiet = "Undefined";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.CurrentLocation = "Corridor to the bridge at USMC Sacred Drop";
            this.Sound = "No You cannot have CatNip on this Ship!" +
                "I am the Captain," +
                " and you will follow my command Soldier or i will have you tossed in the brig for insubordination"; // continues in NorwegianForestCat
            this.CatQuirk = "Iron-will Captain";
        }
        public void GainedCatQuirk()//simple usage of unique variable in a method
        {
            string inputString;
            Console.WriteLine("Has {0} Aquired a new Quirk?  Y/any other for no", this.Name);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Write("What's the Quirk? : ");
                inputString = Console.ReadLine();
                this.CatQuirk = inputString;
                Console.WriteLine("\nQuirk : {0} Has now been registered to {1}",this.CatQuirk, this.Name);
            }
            else
            {
                Console.WriteLine("\n{0} Has no new quirks", this.Name);
            }
        }
    }


    internal class NorwegianForestCat : Cats
    {
        protected bool CatNip; // unique to NorwegianForestCat
        public NorwegianForestCat(string mood, string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, bool catNip)
        {
            this.Breed = "Norwegian forest cat";
            this.CurrentMood = mood;

            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
            this.CurrentLocation = location;
            this.CatNip = catNip;
        }

        public NorwegianForestCat()
        {
            this.Breed = "I'm not a proper Instance";
            this.CurrentMood = "Scared by superior due to drugs have been found";

            this.Name = "Ensign Flick";
            this.NumberOfAppendages = 4;
            this.Age = 256;
            this.AnimalDiet = "Undefined";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.CurrentLocation = "Corridor to the bridge at USMC Sacred Drop";
            this.Sound = "Sir Yes Sir! - (mumbles under breath, you overfloofed wet blanket..)";
            this.CatNip = true;
        }

        public void HazHadCatNip()//simple usage of unique variable in a method
        {
            Console.WriteLine("Has {0} Already had his CatNip?  Y/any other for no", this.Name);
            if (Console.ReadKey().Key == ConsoleKey.Y && this.CatNip == false)
            {
                this.CatNip = true;
                Console.WriteLine("\nThat Sweet Sweet Catnip! {0}", this.Name);
            }
            else
            {
                Console.WriteLine("\n{0} Noo! givez more catnipz!", this.Name);
            }
        }

    }
}
