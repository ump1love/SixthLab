class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is moving\n");
    }
    public void Turn()
    {
        Console.WriteLine("Car is turning");
    }
    public override void LoadPassengers(int count)
    {
        base.LoadPassengers(count);
    }

    public override void DisembarkPassengers(int count)
    {
        base.DisembarkPassengers(count);
    }

    public override void Move() { Drive(); }
}