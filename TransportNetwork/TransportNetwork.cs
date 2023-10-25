class TransportNetwork
{
    Random random = new Random();
    List<(Vehicle vehicle, int density)> vehicles = new List<(Vehicle, int)>();
    private int carsDensity = 0;
    private int busesDensity = 0;
    private int trainsDensity = 0;


    public void AddVehicle(Vehicle vehicle, int density)
    {
        vehicles.Add((vehicle, density));
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        var vehicleToRemove = vehicles.FirstOrDefault(x => x.vehicle == vehicle);
        if (vehicle != null) { vehicles.Remove(vehicleToRemove); }
    }

    public void AmountOfVehicles()
    {
        int carsAmount = 0;
        int busesAmount = 0;
        int trainsAmount = 0;

        foreach ((Vehicle vehicle, int density) in vehicles)
        {
            if (vehicle is Car) { ++carsAmount; carsDensity += density; }
            if (vehicle is Bus) { ++busesAmount; busesDensity += density; }
            if (vehicle is Train) { ++trainsAmount; trainsDensity += density; }
        }

        Console.WriteLine($"\nThere are currently {vehicles.Count} vehicles.\n" +
                          $"Cars: {carsAmount}, with {carsDensity} people in them\n" +
                          $"Buses: {busesAmount}, with {busesDensity} people in them\n" +
                          $"Trains: {trainsAmount}, with {trainsDensity} people in them\n");
    }
    public void MoveVehicles(Route route)
    {
        List<string> intermediateStops = new List<string> { "Street A", "Street B", "Street C", "Street D" };
        List<string> optimizedRoute = route.OptimizeRoute(intermediateStops);

        foreach ((Vehicle vehicle, int density) in vehicles)
        {
            vehicle.Move();
            HandlePassengerManagement(vehicle, density);
        }
    }

    private void HandlePassengerManagement(Vehicle vehicle, int density)
    {
        int passengersToBoard = random.Next(1, density + 1);
        int passengersToAlight = random.Next(1, vehicle.CurrentPassengerCount + 1);

        vehicle.BoardPassengers(passengersToBoard);
        vehicle.AlightPassengers(passengersToAlight);
    }
}