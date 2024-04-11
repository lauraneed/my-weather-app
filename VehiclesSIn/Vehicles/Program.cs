namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Car volvo = new Car(4,5,true,true,"EHSEH22D","teddy",true);
            volvo.StartEngine();
            volvo.Accelerate (50);
            Console.WriteLine("volvo" + volvo.speed);


            Car bmw = new Car(4,5,false,false,"GHETH3D5", "mort",true);
            bmw.StartEngine();
            bmw.Accelerate (330);
            Console.WriteLine("bmw"+ bmw.speed);

            volvo.Decelerate (20);
            Console.WriteLine("volvo" + volvo.speed);

            Car mazda = new Car(4,3,false,true,"GHEST4","bob",false);
            mazda.StartEngine();
            mazda.Accelerate(10);

            double mazdaspeed = mazda.GetCurrentSpeed ();
            Console.WriteLine("mazda" + mazdaspeed);

            Console.WriteLine("volvo have GPS ?" + volvo.HasGps);
            Console.WriteLine("bmw have GPS ?" + bmw.HasGps);
            Console.WriteLine("mazda have GPS ?" + mazda.HasGps);

            Console.WriteLine("volvo doors ?" + volvo.NoOfDoors);
            Console.WriteLine("bmw doors ?" + bmw.NoOfDoors);
            Console.WriteLine("mazda doors ?" + mazda.NoOfDoors);

            volvo.Decelerate(400);
            Console.WriteLine("volvo current" + volvo.speed);

            volvo.Decelerate(500);
            Console.WriteLine("mazda current" + volvo.speed);

            Console.WriteLine("volvo VIN ?" + volvo.VinNumber);
            Console.WriteLine("bmw VIN ?" + bmw.VinNumber);
            Console.WriteLine("mazda VIN ?" + mazda.VinNumber);
        }
    }
}
