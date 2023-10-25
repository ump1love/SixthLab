class Human : Vehicle
{
    public void Walk()
    {
        Console.WriteLine("Human is walking\n");
    }

    public override void Move() { Walk(); }

}