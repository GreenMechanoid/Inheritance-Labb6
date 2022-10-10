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

/*
 * There is so many things i have to tell about this lab..
 * first being pushed to use polymorphism for basic inheritance lab for the newer to programing is just wrong..
 * they have plenty to implement without it.. 
 * the entire section of lessons has been missing a "red thread" in how to learn the sections from classes -> inheritance..
 * Even introducing Abstract classes and Interfaces way before they were supposed to be introduced in the curriculum just muddles the waters on what we're supposed to learn
 * hell even according to the schedule we're not supposed to be introduced to the for-Mentioned Interface until long after this lab is due, so why include it in the lessons???
 * 
 * Meaning this lab has been done to the MINIMUM due to the other class students needing help in understanding almost every lesson.
 * i have although put in How i would do it if Polymorphism was the goal of the lab - which it clearly is not.. it's for basic inheritance
 * 
 * this is draft 6 of the critique, as the other's have been a bit too hot-headed in how they we're written.
 */