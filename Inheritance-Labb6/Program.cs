//Daniel Svensson .Net22 - Lab6 - Arv

using System;
namespace Petting_Zoo //yes im making this a petting zoo, Skritches to the animal! =)
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal anima = new Animal();

            Cats cat = new Cats();

            anima.MakeSound();

            cat.MakeSound();
        }
    }
}
