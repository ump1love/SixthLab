class Route
{
    public List<string> OptimizeRoute(List<string> intermediateStops)
    {
        List<string> optimizedRoute = intermediateStops.OrderBy(x => Guid.NewGuid()).ToList();

        Console.WriteLine("Optimized Route:");
        foreach (var stop in optimizedRoute)
        {
            Console.WriteLine(stop);
        }

        return optimizedRoute;
    }
}