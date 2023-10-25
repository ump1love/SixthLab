class Train : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Train is moving\n");
    }
    public void Turn()
    {
        Console.WriteLine("Train is turning");
    }

    public override void Move() { Drive(); }
}