
class GraphicsEditor
{
    Triangle triangle = new Triangle();
    Circle circle = new Circle();
    Rectangle rectangle = new Rectangle();
    List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();


    public void AddPrimitive()
    {
        primitives.Add(circle);
        primitives.Add(rectangle);
        primitives.Add(triangle);
    }
    public void ChangeScale()
    {
        circle.Scale(8);
        rectangle.Scale(20, 10);
        triangle.Scale(8);
    }

    public void DrawFigure()
    {
        for (int i = 0; i < primitives.Count; i++)
        {
            primitives[i].Draw();
        }
    }
}
