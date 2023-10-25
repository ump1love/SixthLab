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

    public override void Move() { Drive(); }
}