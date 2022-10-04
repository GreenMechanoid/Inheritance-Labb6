//Daniel Svensson .Net22 - Lab6 - Arv

using System;
namespace Petting_Zoo //yes im making this a petting zoo, Skritches to the animals! =)
{
    class Program
    {
        static void Main(string[] args)
        {

            Cats cat = new Cats();

            Sheep sheep = new Sheep();

            cat.MakeSound();

            //cat.AnimalMoveing();
            sheep.AttackedRecently();
            
        }

    }
}


/*  This is me pointing out Flaws in the teaching of Inheritance in the "live classes we do" 
I am making this As simple as possible Due to the fact that compared to the last Laboration
This is a WAAAAY bigger scope than it needs to be for a laboration on Inheritance!
it is litterally 3-4 times larger than the last Laboration on OOP-basics..,
Yet has the same deadline period of 1-2 weeks (functunally it's 4½ days per week if you count the classes where we are supposed to learn this....)

i will not be surprised if we have students that can't complete this Laboration on time
especially since Polymorphism is being explained in conjunction to Inheritance.. It's supposed to come AFTER this...
Perfect Exampel - Virtual and Override Is part of Polymorphism of a class/method/whatever.. yet it's being explained as part of basic inheritance.
also going into Interface's - Abstract classes!!???!! while learning of Basic Inheritance!???!!!
 */