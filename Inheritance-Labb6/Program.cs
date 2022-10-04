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
