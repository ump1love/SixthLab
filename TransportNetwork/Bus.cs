class Bus : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Bus is moving\n");
    }
    public void Turn()
    {
        Console.WriteLine("Bus is turning");
    }

    public override void Move() { Drive(); }
}