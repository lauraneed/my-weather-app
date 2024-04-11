using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace assignment3realworldobject
{
    public class Program
    {

        public myTruck()
        {
            colour = "Pink and Green";
            speed = 100; //100 km / h;
            numberOfDoors = 4;
        }
        //return "";
        public void StartEngine()
        {
            Console.WriteLine("The truck engine has started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("The truck engine has stopped.");
        }

        public void Accelerate()
        {
            speed += 20;
            Console.WriteLine("The truck is now moving at " + speed + " km/h.");



        }
        public void CloseDoor()
        {
            Console.WriteLine("A door of the truck has been closed.");
        }

    }
}
