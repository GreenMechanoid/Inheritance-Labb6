//Daniel Svensson .Net22 - Lab6 - Arv

using System;
using System.Threading;

namespace Petting_Zoo //yes im making this a petting zoo, Skritches to the animals! =)
{
    class Program
    {
        static void Main(string[] args)
        {

            Cats cat = new Cats("Cattington",4,6,"Carnivore"
                ,false,false,false,false,"Meow","Petting pen","Mau","anoyed");
            Console.Write("I am a Cat: ");
            cat.MakeSound();
            Dogs dog = new Dogs("Whoofington",4,12,"Carnivore"
                ,false,false,false,false,"Wooof! Bark!","Petting pen","Great Dane",true);
            Console.Write("I am a dog: ");
            dog.MakeSound();
            Sheep sheep = new Sheep("dorper","Sir Floof",4,7,"Herbivore"
                ,false,true,false,false,"Baaa!","Petting yard",false);
            Console.Write("I am a sheep: ");
            sheep.MakeSound();
            Manx manx = new Manx("Sour","Lemon-Drop",4,5,"Carnivore"
                ,false,false,false,false,"mew","it's Pen","destroyer of mugs");
            Console.Write("I am a Manx: ");
            manx.MakeSound();
            NorwegianForestCat norwForest = new NorwegianForestCat("Melancholic","MelloMan",4,4,"Carnivore"
                ,false,false,false,false,"Mew mew Meouw","own Pen",true);
            Console.Write("I am a NorwegianForestCat: ");
            norwForest.MakeSound();

            Thread.Sleep(3000); //putting the program to sleep for 3 sec, so user can read the outputs
            //calling what unique methods the classes have.
            manx.GainedCatQuirk();
            Thread.Sleep(3000);

            norwForest.HazHadCatNip();
            Thread.Sleep(3000);

            cat.ChangeMood();
            Thread.Sleep(3000);

            sheep.AttackedRecently();
            Thread.Sleep(3000);

            dog.PlayTime();
        }

    }
}
