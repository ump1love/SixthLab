class Rectangle: GraphicPrimitive
{

    private float width;
    private float height;

    public float Width
    {
        get { return width; }
        set { width = value; }
    }
    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public override void Draw()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
    public override void Scale(float factor) { }
    public override void Scale(float factor, float factorSecond)
    {
        Width = factor;
        Height = factorSecond;
    }
    public override void Move(int y, int x)
    {
        for (int temp = 0; temp < y; temp++)
        {
            Console.WriteLine();
        }
        for (int i = 0; i < Height; i++)
        {
            for (int temp = 0; temp < x; temp++)
            {
                Console.Write(' ');
            }

            for (int j = 0; j < Width; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}