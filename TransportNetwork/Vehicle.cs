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

    public virtual void LoadPassengers(int count)
    {
        Console.WriteLine($"Loading {count} passengers into {Name}");
    }

    public virtual void DisembarkPassengers(int count)
    {
        Console.WriteLine($"Disembarking {count} passengers from {Name}");
    }


    public abstract void Move();
}