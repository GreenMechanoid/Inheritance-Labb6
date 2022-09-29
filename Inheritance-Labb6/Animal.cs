using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Labb6
{
    internal class Animal
    {
        string Name = "";
        int NumberOfAppendages = 0;
        int Age = 0;
        int Population = 0;
        string AnimalType = ""; // Carnivore, Herbivore, Omnivore
        bool HasYoung = false; // assuming normaly that they dont have young due to Zoo enviroment
        bool HasBeenFedToday = false; // assuming no they hav'nt been fed yet
        bool Wild = false; //assuming the Animal is Wild 
        string sound = "";

        void makeSounds(string makeSounds)
        {
            Console.WriteLine(makeSounds);
        }

        void ÉnclosureMaintenance() 
        {
            
        }

    }


    internal class Cats : Animal 
    {
        string _Breed = "Tabby mcTabbington";
        bool _NeedsPetting = false;
    }

    internal class Dogs : Animal
    {

    }

    internal class Wolf : Dogs
    {
        
    }
    internal class Leopard : Cats 
    { 
        
    }

    internal class ThundraWolf : Dogs
    {
        bool _EnclosureIsColdEnough = false; //assuming that the AC has failed during the night

    }


}
