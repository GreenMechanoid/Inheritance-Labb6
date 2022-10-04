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
        protected string CurrentMood; // unique identifier for Cats, as they can be fickle

        public Cats(string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, string breed, string mood)
        {
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

    }

    internal class Manx : Cats
    {
        protected string CatQuirk; // unique to Manx
        public Manx(string breed, string mood, string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, string catQuirk)
        {
            this.Breed = breed;
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

    }


    internal class NorwegianForestCat : Cats
    {
        protected string FurPattern; // unique to NorwegianForestCat
        public NorwegianForestCat(string breed, string mood, string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, string furPattern)
        {
            this.Breed = breed;
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
            this.FurPattern = furPattern;
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
            this.FurPattern = "Speckeled gray long hair";
        }

    }
}
