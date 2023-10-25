class Program
{
    public static void Main()
    {
        Random random = new Random();
        TransportNetwork transportNetwork = new TransportNetwork();
        Car car = new Car { Speed = 70, Capacity = 6, Name = "Car" };
        Bus bus = new Bus { Speed = 50, Capacity = 17, Name = "Bus" };
        Train train = new Train { Speed = 80, Capacity = 100, Name = "Train" };

        for (int i = 0; i < random.Next(10,30); i++)
        {
            transportNetwork.AddVehicle(car, random.Next(1,6));
        }
        for (int i = 0;i < random.Next(7); i++)
        {
            transportNetwork.AddVehicle(bus, random.Next(1, 17));
        }
        for (int i = 0; i < random.Next(2); i++)
        {
            transportNetwork.AddVehicle(train, random.Next(1, 100));
        }


        Route route = new Route();
        transportNetwork.MoveVehicles(route);
        transportNetwork.AmountOfVehicles();


    }
}