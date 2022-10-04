using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        protected string AnimalDiet; // Carnivore, Herbivore, Omnivore
        protected bool HasYoung; // assuming normaly that they dont have young due to Zoo enviroment
        protected bool HasBeenFedToday; // assuming no they hav'nt been fed yet
        protected bool Wild; //assuming the Animal is Wild or New to the Zoo
        protected string Sound;
        protected bool SentientErrorCheck; //joke varaible for checking default class values.
        protected string CurrentLocation;
        protected string Breed;

        public Animal() //Default variable value's
                           //Nonsensical variables for animals, but kinda funny for debugging
        {

            this.Name = "Rules of the internet: if enountered Something went Wrong...";
            this.NumberOfAppendages = 63;
            this.Age = 34;
            this.AnimalDiet = "Not an Animal in the typical sense";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = false;
            this.Sound = "There is no sound";
            this.SentientErrorCheck = false;
            this.CurrentLocation = "IN SPAAAAACCCCCCEEEEEE!!!!!";
            this.Breed = "does not exist";
        }
        public Animal(string name, int appendages,int age,string animalDiet
                ,bool hasYoung,bool hasBeenFed,bool wild,string sound, string location, string breed)
            //full population of variables for the Base Animal Class,
        {
            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.AnimalDiet = animalDiet;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = hasBeenFed;
            this.Wild = wild;
            this.Sound = sound;
            this.SentientErrorCheck = false;
            this.CurrentLocation = location;
            this.Breed = breed;
        }

        public virtual void MakeSound()
        {
            //Method asks for the Obj's Sound variable and prints it to console, if it's empty it will use the default value
            Console.WriteLine(this.Sound);
        }
        
        public void AnimalMoveing() // just a simple reassignement of the location and printing of it again
        {
            Console.WriteLine(this.Name + "'s Current Location: {0}",this.CurrentLocation);
            Console.WriteLine("Where will the animal be moved?");
            this.CurrentLocation = Console.ReadLine();
            Console.WriteLine(this.Name + " Has now been moved to : {0}", this.CurrentLocation);
        }
        
        public void FeedingTime()
        {
            
            Console.WriteLine("Has {0} Already been fed?  Y/any other for no", this.Name);
            if (Console.ReadKey().Key == ConsoleKey.Y && this.HasBeenFedToday == false)
            {
                Console.WriteLine("\nThat calls for some suppertime then!. Enjoy your meal {0}", this.Name);
                this.HasBeenFedToday = true;
            }
            else
            {
                Console.WriteLine("\n{0} is already full from dinner and snacks!", this.Name);
            }
        }
    }

    internal class Dogs : Animal
    {
        protected bool WantsToPlay; // unique for doggos
        public Dogs()
        //empty with default values
        {
            this.Breed = "Labby Sloberton";
            this.WantsToPlay = false; // no it's sleepy time! 

            this.Name = "'Sir Woofington'";
            this.NumberOfAppendages = 4;
            this.Age = 1248;
            this.AnimalDiet = "Carnivore";
            this.HasYoung = false;
            this.HasBeenFedToday = false;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.CurrentLocation = "Secret Base";
            this.Sound = "Woof!, Don't trust the cats. they are up to NO good i tell you!";

        }
        public Dogs(string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild,bool sentient, string sound, string location, string breed, bool wantsToPlay)
        {

            this.Breed = breed;
            this.WantsToPlay = wantsToPlay;

            this.Name = name;
            this.NumberOfAppendages = appendages;
            this.Age = age;
            this.AnimalDiet = animalType;
            this.HasYoung = hasYoung;
            this.HasBeenFedToday = beenFed;
            this.Wild = wild;
            this.SentientErrorCheck = sentient;
            this.CurrentLocation = location;
            this.Sound = sound;
        }
        public void PlayTime()//simple usage of unique variable in a method
        {
            Console.WriteLine("Has {0} Played with a Visitor Recently? Y/any other for no", this.Name);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\n{0} Is all tuckerd out from playing", this.Name);
                this.WantsToPlay = true;
            }
            else
            {
                Console.WriteLine("\nThat calls for some playtime! get to it {0}", this.Name);
                this.WantsToPlay = false;
            }
        }
    }

    internal class Sheep : Animal
    {
        bool HasAttackedRecently; //assuming it's the wrong season for it currently also unique for the sheep

        public Sheep()
        //empty with default values
        {
            this.Breed = "Master of Shears - Ladoum";
            this.Name = "Doc Shearington'";
            this.NumberOfAppendages = 4;
            this.Age = 1248;
            this.AnimalDiet = "Herbivore";
            this.HasYoung = false;
            this.HasBeenFedToday = true;
            this.Wild = true;
            this.SentientErrorCheck = true;
            this.CurrentLocation = "Corridor to Medbay of USMC Sacred Drop";
            this.Sound = "BaaaHHH, Stop yelling near the medical ward!";
            this.HasAttackedRecently = true;
        }
        public Sheep(string breed, string name, int appendages, int age
            , string animalType, bool hasYoung, bool beenFed
            , bool wild, bool sentient, string sound, string location, bool hasAttackedRecently)
        {

            this.Breed = breed;
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
            this.HasAttackedRecently = hasAttackedRecently;
        }

        public void AttackedRecently()//simple usage of unique variable in a method
        {
            Console.WriteLine("Has {0} Attacked a Visitor Recently? Y/any other for no", this.Name);

            if (Console.ReadKey().Key == ConsoleKey.Y) 
            {
                this.CurrentLocation = "Isolation";
                Console.WriteLine("\nThat calls for some time alone then. {0} will be moved to {1}", this.Name,this.CurrentLocation);
            }
            else
            {
                Console.WriteLine("\n{0} Uses Headbutt!.. But it missed..",this.Name);
            }
        }

    }
    
}
