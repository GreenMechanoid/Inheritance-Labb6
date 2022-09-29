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
        protected string _Name = "Rules of the internet";
        protected int _NumberOfAppendages = 34;
        protected int _Age = 63;
        protected int _Population = 35;
        protected string _AnimalType = ""; // Carnivore, Herbivore, Omnivore
        protected bool _HasYoung = false; // assuming normaly that they dont have young due to Zoo enviroment
        protected bool _HasBeenFedToday = false; // assuming no they hav'nt been fed yet
        protected bool _Wild = false; //assuming the Animal is Wild or New to the Zoo
        protected string _Sound = "";
        protected bool _SentientErrorCheck = false; // funny joke varaible for checking default class values.

        public void makeSounds(string makeSounds)
        {
            Console.WriteLine(makeSounds);
        }

        void ÉnclosureMaintenance() 
        {
            
        }

    }


    internal class Cats : Animal 
    {
        protected string _Breed = "Tabby mcTabbington";
        protected bool _WantsPetting = false;

        protected Cats()
        {
            this._Name = "Terror of McError";
            this._NumberOfAppendages = 4;
            this._Age = 6428;
            this._Population = 1;
            this._AnimalType = "Carnivore";
            this._HasYoung = false;
            this._HasBeenFedToday = false;
            this._Wild = true;
            this._SentientErrorCheck = true;
            this._Sound = "Meow!, i'm an Interdemisional being, stop fussing over me mortal!";

        }//empty with default values

        protected Cats(string name, int appendages, int age, int population
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound)
        {
            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalType = animalType;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = beenFed;
            this._Wild = wild;
            this._SentientErrorCheck = sentient;
            this._Sound = sound;
        }
    }

    internal class Dogs : Animal
    {
        protected string _Breed = "Labby Sloberton";
        protected bool _WantsToPlay = false; // no it's sleepy time! 
        protected Dogs()
        {
            this._Name = "'Sir Woofington'";
            this._NumberOfAppendages = 4;
            this._Age = 1248;
            this._Population = 1;
            this._AnimalType = "Carnivore";
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
            this._Name = name;
            this._NumberOfAppendages = appendages;
            this._Age = age;
            this._Population = population;
            this._AnimalType = animalType;
            this._HasYoung = hasYoung;
            this._HasBeenFedToday = beenFed;
            this._Wild = wild;
            this._SentientErrorCheck = sentient;
            this._Sound = sound;

            this._Breed = breed;
            this._WantsToPlay = wantsToPlay;
        }
    }

    internal class Sheep : Animal
    {
        bool _hasBeenSheared = false; //assuming it's the wrong season for it currently
    }
    internal class Manx : Cats 
    {

        Manx(string breed, bool petting, string name)
        {
            this._Breed = breed;
            this._WantsPetting = petting;
            this._Name = name;
        }

    }


    internal class NorwegianForestCat : Cats
    {
        NorwegianForestCat(string breed, bool petting, string name)
        {
            this._Breed = breed;
            this._WantsPetting = petting;
            this._Name = name;
        }
    }


}
