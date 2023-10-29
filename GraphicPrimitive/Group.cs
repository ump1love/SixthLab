class Group : GraphicPrimitive
{
    Triangle triangle = new Triangle();
    Circle circle = new Circle();
    Rectangle rectangle = new Rectangle();
    private List<GraphicPrimitive> groupPrimitives = new List<GraphicPrimitive>();

    public void AddPrimitive()
    {
        groupPrimitives.Add(circle);
        groupPrimitives.Add(rectangle);
        groupPrimitives.Add(triangle);
    }

    public override void Draw()
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Move(x, y);
        }
    }

    public override void Scale(float factor)
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Scale(factor);
        }
    }

    public override void Scale(float factor, float factorSecond)
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Scale(factor, factorSecond);
        }
    }

    public void Tmp()
    {
        for (int i = 0; i < groupPrimitives.Count; i++) { Console.WriteLine(groupPrimitives[i]); }
    }
}