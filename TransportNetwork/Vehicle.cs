abstract class Vehicle
{
    private int speed;
    private int capacity;
    private int density;
    private string name;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }
    public int Density
    {
        get { return density; }
        set { density = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract void Move();

    private int currentPassengerCount;

    public int CurrentPassengerCount
    {
        get { return currentPassengerCount; }
        set { currentPassengerCount = value; }
    }

    public void BoardPassengers(int passengers)
    {
        if (currentPassengerCount + passengers <= Capacity)
        {
            currentPassengerCount += passengers;
            Console.WriteLine($"{Name} boarded {passengers} passengers. Current count: {currentPassengerCount}");
        }
        else
        {
            Console.WriteLine($"Not enough space in {Name} for {passengers} passengers.");
        }
    }

    public void AlightPassengers(int passengers)
    {
        if (currentPassengerCount - passengers >= 0)
        {
            currentPassengerCount -= passengers;
            Console.WriteLine($"{Name} alighted {passengers} passengers. Current count: {currentPassengerCount}");
        }
        else
        {
            Console.WriteLine($"Attempted to alight more passengers from {Name} than there are on board.");
        }
    }
}