class TransportNetwork
{
    Random random = new Random();
    List<(Vehicle vehicle, int passengers)> vehicles = new List<(Vehicle, int)>();

    private int carsPassengers;
    private int busesPassengers;
    private int trainsPassengers;
    private int carsAmount;
    private int busesAmount;
    private int trainsAmount;


    public void AddVehicle(Vehicle vehicle, int passengers)
    {
        vehicles.Add((vehicle, passengers));
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        var vehicleToRemove = vehicles.FirstOrDefault(x => x.vehicle == vehicle);
        if (vehicle != null)
        {
            vehicles.Remove(vehicleToRemove);
            SettingVehiclesAndPassengers();
        }
    }

    public void SettingVehiclesAndPassengers()
    {
        carsAmount = 0;
        carsPassengers = 0;
        busesAmount = 0;
        busesPassengers = 0;
        trainsAmount = 0;
        trainsPassengers = 0;

        foreach ((Vehicle vehicle, int passengers) in vehicles)
        {
            if (vehicle is Car) { ++carsAmount; carsPassengers += passengers; vehicle.LoadPassengers(passengers); int passengersToDisembark = random.Next(1, passengers + 1); vehicle.DisembarkPassengers(passengersToDisembark); }
            if (vehicle is Bus) { ++busesAmount; busesPassengers += passengers; vehicle.LoadPassengers(passengers); int passengersToDisembark = random.Next(1, passengers + 1); vehicle.DisembarkPassengers(passengersToDisembark); }
            if (vehicle is Train) { ++trainsAmount; trainsPassengers += passengers; vehicle.LoadPassengers(passengers); int passengersToDisembark = random.Next(1, passengers + 1); vehicle.DisembarkPassengers(passengersToDisembark); }
        }
    }

    public void AmountOfVehicles()
    {
        Console.WriteLine($"\nThere are currently {vehicles.Count} vehicles.\n" +
                          $"Cars: {carsAmount}, with {carsPassengers} people in them\n" +
                          $"Buses: {busesAmount}, with {busesPassengers} people in them\n" +
                          $"Trains: {trainsAmount}, with {trainsPassengers} people in them\n");

    }


}