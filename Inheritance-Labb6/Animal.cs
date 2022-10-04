using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Petting_Zoo
{
    internal class Animal  
        //Baseclass for Animals meant for inheriting the values in a child-class
        
    {
        protected string Name; // name for the Animal in question
        protected int NumberOfAppendages;
        protected int Age; // if applicable
        protected int Population; // the sheer number of Animals of this type, added for things like schools of fish or a murder of crows
        protected string AnimalDiet; // Carnivore, Herbivore, Omnivore
        protected bool HasYoung; // assuming normaly that they dont have young due to Zoo enviroment
        protected bool HasBeenFedToday; // assuming no they hav'nt been fed yet
        protected bool Wild; //assuming the Animal is Wild or New to the Zoo
        protected string Sound;
        protected bool SentientErrorCheck; //joke varaible for checking default class values.
        protected bool IsAvailableForPublic = false;
        protected string Breed;

        protected Animal() //Default variable value's
                           //Nonsensical variables for animals, but kinda funny for debugging
        {

            this.Name = "Rules of the internet: if enountered Something went Wrong...";
            this.NumberOfAppendages = 63;
            this.Age = 34;
            this.Population = 35;
            this.AnimalDiet = "Not an Animal in the typical sense";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = false;
            this.Sound = "There is no sound";
            this.SentientErrorCheck = false;
            this.Breed = "does not exist";
        }
        protected Animal(string name, int appendages,int age,int population,string animalDiet
                ,bool hasYoung,bool hasBeenFed,bool wild,string sound, string breed)
            //full population of variables for the Base Animal Class,
        {
            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.Population = population;
            this.AnimalDiet = animalDiet;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = hasBeenFed;
            this.Wild = wild;
            this.Sound = sound;
            this.SentientErrorCheck = false;
            this.Breed = breed;
        }

        public void MakeSound()
        {
            //Method asks for the Obj's Sound variable and prints it to console, if it's empty it will use the default value
            Console.WriteLine(this.Sound);
        }
        
        public void MakeNewAnimal(string name, int appendages, int age, int population, string animalDiet
                , bool hasYoung, bool hasBeenFed, bool wild, string sound) // when animals arrive to the zoo
        {
            
        }

    }


    internal class Cats : Animal 
    {
        protected string CurrentMood; // unique identifier for Cats, as they can be fickle

        public Cats(string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string breed, string mood)
        {
            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.Population = population;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;

            this.Breed = breed;
            this.CurrentMood = mood;
        }
        public Cats()
        {
            this.Breed = "Tabby mcTabbington";
            this.CurrentMood = "Not Amused";

            this.Name = "Terror of McError";
            this.NumberOfAppendages = 4;
            this.Age = 6428;
            this.Population = 1;
            this.AnimalDiet = "Carnivore";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.Sound = "Meow!, i'm a ExtraSolar being, stop fussing over me Human!";

        }//empty with default values

    }

    internal class Dogs : Animal
    {
        protected bool WantsToPlay; // unique for doggos
        public Dogs()
        {
            this.Breed = "Labby Sloberton";
            this.WantsToPlay = false; // no it's sleepy time! 

            this.Name = "'Sir Woofington'";
            this.NumberOfAppendages = 4;
            this.Age = 1248;
            this.Population = 1;
            this.AnimalDiet = "Carnivore";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.Sound = "Woof!, Don't trust the cats. they are up to NO good i tell you!";

        }//empty with default values
        public Dogs(string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild,bool sentient, string sound,string breed, bool wantsToPlay)
        {

            this.Breed = breed;
            this.WantsToPlay = wantsToPlay;

            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.Population = population;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
        }

    }

    internal class Sheep : Animal
    {
        bool HasBeenSheared = false; //assuming it's the wrong season for it currently also unique for the sheep

        public Sheep()
        {
            this.Breed = "Master of Shears - Ladoum";
            this.Name = "Doc Shearington'";
            this.NumberOfAppendages = 4;
            this.Age = 1248;
            this.Population = 1;
            this.AnimalDiet = "Herbivore";
            this.HasYoung = false;
            this.HasBeenFedToday = true;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.Sound = "BaaaHHH, Stop yelling near the medical ward!";
            this.HasBeenSheared = true;
        }
        public Sheep(string breed, string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, bool hasBeenSheared)
        {
            this.HasBeenSheared = hasBeenSheared;

            this.Breed = breed;
            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.Population = population;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
        }

    }
    internal class Manx : Cats 
    {
        protected string CatQuirk; // unique to Manx
        public Manx(string breed, string mood, string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string catQuirk)
        {
            this.Breed = breed;
            this.CurrentMood = mood;

            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.Population = population;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
            this.CatQuirk = catQuirk;
        }
        public Manx()
        {
            this.Breed = "I'm not a proper Instance";
            this.CurrentMood = "Pissed at subordinate for drugs";

            this.Name = "Captain. Floofers the second";
            this.NumberOfAppendages = 4;
            this.Age = 8844;
            this.Population = 1;
            this.AnimalDiet = "Undefined";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.Sound = "No You cannot have CatNip on this Ship!" +
                "I am the Captain," +
                " and you will follow my command Soldier or i will have you tossed in the brig for insubordination"; // continues in NorwegianForestCat
            this.CatQuirk = "Iron-will Captain";
        }

    }


    internal class NorwegianForestCat : Cats
    {
        protected string FurPattern; // unique to NorwegianForestCat
        public NorwegianForestCat(string breed, string mood, string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string furPattern)
        {
            this.Breed = breed;
            this.CurrentMood = mood;

            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.Population = population;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.Sound = sound;
            this.FurPattern = furPattern;
        }

        public NorwegianForestCat()
        {
            this.Breed = "I'm not a proper Instance";
            this.CurrentMood = "Scared by superior due to drugs have been found";

            this.Name = "Ensign Flick";
            this.NumberOfAppendages = 4;
            this.Age = 256;
            this.Population = 1;
            this.AnimalDiet = "Undefined";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.Sound = "Sir Yes Sir! - (mumbles under breath, you overfloofed wet blanket..)";
            this.FurPattern = "Speckeled gray long hair";
        }

    }
}
