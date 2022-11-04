namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your vehicle have?");
            string numberOfWheels = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle.Drive();
        }
    }
}
