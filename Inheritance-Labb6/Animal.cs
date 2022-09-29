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
        //Nonsensical variables for animals, but kinda funny for debugging
    {
        protected string _Name;
        protected int _NumberOfAppendages;
        protected int _Age;
        protected int _Population;
        protected string _AnimalDiet; // Carnivore, Herbivore, Omnivore
        protected bool _HasYoung; // assuming normaly that they dont have young due to Zoo enviroment
        protected bool _HasBeenFedToday; // assuming no they hav'nt been fed yet
        protected bool _Wild; //assuming the Animal is Wild or New to the Zoo
        protected string _Sound;
        protected bool _SentientErrorCheck; // funny joke varaible for checking default class values.


        protected Animal() //Default variable value's
        {
            this._Name = "Rules of the internet: if enountered Something went Wrong...";
            this._NumberOfAppendages = 63;
            this._Age = 34;
            this._Population = 35;
            this._AnimalDiet = "Not an Animal in the typical sense";
            this._HasYoung = false;
            this._HasBeenFedToday = false;
            this._Wild = false;
            this._Sound = "There is no sound";
            this._SentientErrorCheck = false;
        }
        protected Animal(string name, int appendages,int age,int population,string animalDiet
                ,bool hasYoung,bool hasBeenFed,bool wild,string sound,bool sentient)
            //full population of variables for the Base Animal Class,
            //name - if it's a wild animal leave as Unknown or empty
            //animalDiet refers to if it's a Carnivore,Herbivore,Omnivore
        {
            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalDiet = animalDiet;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = hasBeenFed;
            this._Wild = wild;
            this._Sound = sound;
            this._SentientErrorCheck = sentient;
        }

        public void MakeSound()
        {
            //Method asks for the Obj's Sound variable and prints it to console, if it's empty it will use the default value
            Console.WriteLine(this._Sound);
        }
        

    }


    internal class Cats : Animal 
    {
        protected string _Breed;
        protected bool _WantsPetting;


        protected Cats(string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string breed, bool petting)
        {
            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalDiet = animalType;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = beenFed;
            this._Wild = wild;
            this._SentientErrorCheck = sentient;
            this._Sound = sound;

            this._Breed = breed;
            this._WantsPetting = petting;
        }
        protected Cats()
        {
            this._Breed = "Tabby mcTabbington";
            this._WantsPetting = false;

            this._Name = "Terror of McError";
            this._NumberOfAppendages = 4;
            this._Age = 6428;
            this._Population = 1;
            this._AnimalDiet = "Carnivore";
            this._HasYoung = false;
            this._HasBeenFedToday = false;
            this._Wild = true;
            this._SentientErrorCheck = true;
            this._Sound = "Meow!, i'm an Interdemisional being, stop fussing over me mortal!";

        }//empty with default values
    }

    internal class Dogs : Animal
    {
        protected string _Breed;
        protected bool _WantsToPlay; 
        protected Dogs()
        {
            this._Breed = "Labby Sloberton";
            this._WantsToPlay = false; // no it's sleepy time! 

            this._Name = "'Sir Woofington'";
            this._NumberOfAppendages = 4;
            this._Age = 1248;
            this._Population = 1;
            this._AnimalDiet = "Carnivore";
            this._HasYoung = false;
            this._HasBeenFedToday = false;
            this._Wild = true;
            this._SentientErrorCheck = true;
            this._Sound = "Woof!, Don't trust the cats. they are up to NO good i tell you!";

        }//empty with default values
        protected Dogs(string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild,bool sentient, string sound,string breed, bool wantsToPlay)
        {

            this._Breed = breed;
            this._WantsToPlay = wantsToPlay;

            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalDiet = animalType;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = beenFed;
            this._Wild = wild;
            this._SentientErrorCheck = sentient;
            this._Sound = sound;
        }
    }

    internal class Sheep : Animal
    {
        bool _hasBeenSheared = false; //assuming it's the wrong season for it currently
    }
    internal class Manx : Cats 
    {


        Manx(string breed, bool petting, string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound) // 
        {
            this._Breed = breed;
            this._WantsPetting = petting;

            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalDiet = animalType;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = beenFed;
            this._Wild = wild;
            this._SentientErrorCheck = sentient;
            this._Sound = sound;
        }
        Manx()
        {
            this._Breed = "I'm not a proper Instance";
            this._WantsPetting = false;

            this._Name = "Admiral Floofers";
            this._NumberOfAppendages = 4;
            this._Age = 8844;
            this._Population = 1;
            this._AnimalDiet = "Undefined";
            this._HasYoung = false;
            this._HasBeenFedToday = false;
            this._Wild = true;
            this._SentientErrorCheck = true;
            this._Sound = "I am the Admiral," +
                " and you will follow my command Soldier or i will have you tossed in the brig for insubordination";
        }

    }


    internal class NorwegianForestCat : Cats
    {
        
        NorwegianForestCat(string breed, bool petting, string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound)
        {
            this._Breed = breed;
            this._WantsPetting = petting;

            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalDiet = animalType;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = beenFed;
            this._Wild = wild;
            this._SentientErrorCheck = sentient;
            this._Sound = sound;
        }

        NorwegianForestCat()
        {
            this._Breed = "I'm not a proper Instance";
            this._WantsPetting = false;

            this._Name = "Ensign Flick";
            this._NumberOfAppendages = 4;
            this._Age = 256;
            this._Population = 1;
            this._AnimalDiet = "Undefined";
            this._HasYoung = false;
            this._HasBeenFedToday = false;
            this._Wild = true;
            this._SentientErrorCheck = true;
            this._Sound = "Sir Yes Sir! - (mumbles under breath, you overfloofed wet blanket..)";
        }
    }


}
