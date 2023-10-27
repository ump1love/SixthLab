abstract class GraphicPrimitive
{
    private int x;
    private int y;

    public int X
    {
        get { return x;}
        set { x = value; }
    }
    public int Y
    {
        get { return y;}
        set { y = value; }
    }

    public void Draw() { }

    public void Move(int x, int y) { }

}