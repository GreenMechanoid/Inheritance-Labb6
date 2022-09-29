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

        void MakeSomeSounds(string makeSounds)
        {
            Console.WriteLine(makeSounds);
        }

    }


    internal class Cats : Animal 
    {
        string _Breed = "";
        bool _NeedsPetting = false;
    }

    internal class Wolf : Animal
    {
        
    }

    internal class Octopus : Animal
    {
        bool _HasEscapedRecently = false; // notorius for escaping thier tanks
    }

    internal class Leopard : Cats 
    { 
        
    }

    internal class ThundraWolf : Animal
    {
        bool _EnclosureIsColdEnough = false; //assuming that the AC has failed during the night

    }


}
