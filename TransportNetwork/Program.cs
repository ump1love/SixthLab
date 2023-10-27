class Program
{
    public static void Main()
    {
        Random random = new Random();
        TransportNetwork transportNetwork = new TransportNetwork();
        Route route = new Route("City A", "City B");

        Car car = new Car { Speed = 70, Capacity = 6, Name = "Car" };
        Bus bus = new Bus { Speed = 50, Capacity = 17, Name = "Bus" };
        Train train = new Train { Speed = 80, Capacity = 100, Name = "Train" };
        Human human = new Human { Speed = 10, Capacity = 1, Name = "Human" };

        int carsAmount = random.Next(10, 30);
        int busesAmount = random.Next(7);
        int trainsAmount = random.Next(2);

        for (int i = 0; i < carsAmount; i++)
        {
            transportNetwork.AddVehicle(car, random.Next(1, 6));
        }
        for (int i = 0; i < busesAmount; i++)
        {
            transportNetwork.AddVehicle(bus, random.Next(1, 17));
        }
        for (int i = 0; i < trainsAmount; i++)
        {
            transportNetwork.AddVehicle(train, random.Next(1, 100));
        }

        for (int i = 0; i < 5; i++)
        {
            transportNetwork.SettingVehiclesAndPassengers();
            transportNetwork.AmountOfVehicles();

            int vehicleChoice = random.Next(1, 8);
            switch (vehicleChoice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    if (carsAmount >= 1)
                    {
                        bool carOptimisation = route.RouteOptimisation(car);
                        if (carOptimisation) { transportNetwork.RemoveVehicle(car); car.Turn(); }
                        else if (!carOptimisation) { car.Drive(); }
                        transportNetwork.SettingVehiclesAndPassengers();
                    }
                    else { Console.WriteLine("Route optimisation chosed train, but there are no cars"); }
                    break;
                case 5:
                case 6:
                    if (busesAmount >= 1)
                    {
                        bool busOptimisation = route.RouteOptimisation(bus);
                        if (busOptimisation) { transportNetwork.RemoveVehicle(bus); bus.Turn(); }
                        else if (!busOptimisation) { bus.Drive(); }
                        transportNetwork.SettingVehiclesAndPassengers();
                    }
                    else { Console.WriteLine("Route optimisation chosed train, but there are no buses"); }
                    break;
                case 7:
                    if (trainsAmount >= 1)
                    {
                        bool trainOptimisation = route.RouteOptimisation(train);
                        if (trainOptimisation) { transportNetwork.RemoveVehicle(train); train.Turn(); }
                        else if (!trainOptimisation) { train.Drive(); }
                        transportNetwork.SettingVehiclesAndPassengers();
                    }
                    else { Console.WriteLine("Route optimisation chosed train, but there are no trains"); }
                    break;
                case 8:
                    Console.WriteLine("There is always at least one human\n");
                    human.Move();
                    break;

            }
        }
        transportNetwork.AmountOfVehicles();
    }
}