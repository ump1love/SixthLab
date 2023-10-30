class Program
{

    public static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();
        Group group = new Group();


        group.AddPrimitive();
        group.Scale(8);
        group.Scale(20, 10);
        group.Move(10, 10);
    }
}