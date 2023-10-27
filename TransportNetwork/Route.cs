class Route
{
    Random random = new Random();
    TransportNetwork transportNetwork = new TransportNetwork();

    private string startPoint;
    private string endPoint;

    public Route(string startPoint, string endPoint)
    {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }

    public bool RouteOptimisation(Vehicle vehicle)
    {
        int temp = random.Next(1, 4);

        Console.WriteLine($"Optimising route for {vehicle.Name} from {startPoint} to {endPoint}");
        switch (temp)
        {
            case 1:
            case 2:
                Console.WriteLine($"{vehicle.Name} decided to move forward according to route optimisation"); return false;
            case 3:
            case 4:
                Console.WriteLine($"{vehicle.Name} decided to turn accourding to route optimisation");
                transportNetwork.RemoveVehicle(vehicle);
                return true;
            default: Console.WriteLine("Something went wrong in RouteOptimisation"); return false;
        }

    }
}