namespace ObjectOrientation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square mysquare = new Square(50);
            Console.WriteLine(mysquare.GetArea());
        }
    }
}
