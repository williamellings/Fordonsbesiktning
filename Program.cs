namespace Fordonsbesiktning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mekonmen måste kolla din bil");
            Vehicle vehicle = new Vehicle(); //objekt

            vehicle.CheckInspection();
        }
    }
}
